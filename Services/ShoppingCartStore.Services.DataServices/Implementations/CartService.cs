﻿namespace ShoppingCartStore.Services.DataServices.Implementations
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using ShoppingCartStore.Common.Constants;
    using ShoppingCartStore.Common.ViewModels.Cart;
    using ShoppingCartStore.Data.Common.Repositories;
    using ShoppingCartStore.Models;
    using SoppingCartStore.Common.Helpers;

    public class CartService : BaseService<Cart>, ICartService
    {
        IItemService _itemService;

        public CartService(IRepository<Cart> repository, IMapper mapper
            , UserManager<Customer> userManager, IItemService itemService)
            : base(repository, mapper, userManager)
        {
            _itemService = itemService;
        }

        public async Task AddToPersistedCartAsync(string productId, string username)
        {
            var cart = FindByUsername(username);
            var item = await _itemService
                .FindByProductIdAndCustomerUsernameAsync(productId, username);

            if (cart == null)
            {
                var customer = await UserManager.FindByNameAsync(username);
                var cartId = await CreateCart(customer);
                await _itemService.CreateAsync(productId, 1, cartId);
            }
            else
            {
                if (item != null)
                {
                    await _itemService.UpdateItemProductQuantityAsync(item.Id, 1);
                }
                else
                {
                    await _itemService.CreateAsync(productId, 1, cart.Id);
                }
            }
        }

        public async Task AddToSessionCartAsync(string productId, ISession session)
        {
            if (SessionHelper.GetObjectFromJson<int>(session, CartConstants.ProductCount) == 0)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item(productId, 1));
                SessionHelper.SetObjectAsJson(session, CartConstants.Cart, cart);

                // Initial product count
                SessionHelper.SetObjectAsJson(session, CartConstants.ProductCount, 1);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(session, "cart");
                int index = doesExist(productId, session);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item(productId, 1));
                }

                SessionHelper.SetObjectAsJson(session, CartConstants.Cart, cart);

                // Incrementing the product counter
                int productCount = SessionHelper.GetObjectFromJson<int>(session, CartConstants.ProductCount);
                SessionHelper.SetObjectAsJson(session, CartConstants.ProductCount, productCount + 1);
            }
        }

        private void AddItemsToSession(List<Item> items, ISession session)
        {
            List<Item> resultItems = new List<Item>();

            foreach(var item in items)
            {
                // To avoid JSON "Error Self referencing loop"
                item.Cart = null;

                resultItems.Add(item);
            }

            SessionHelper.SetObjectAsJson(session, CartConstants.Cart, resultItems);
        }

        private int doesExist(string id, ISession session)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(session, CartConstants.Cart);
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].ProductId.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

        public int? GetProductCountFromSession(ISession session)
        {
            int? count = SessionHelper.GetObjectFromJson<int>(session, CartConstants.ProductCount);
            if (count != 0)
            {
                return count;
            }
            else
            {
                return 0;
            }
        }

        public async Task MigrateSessionProductsAsync(string userEmail, ISession session)
        {
            var customer = await UserManager.FindByEmailAsync(userEmail);
            var persistedCart = this.Repository.FindById(customer.CartId);

            if (persistedCart != null)
            {
                await this.DeletePersistedCart(persistedCart);
            }

            string newDbCartId = await this.CreateCart(customer);

            var cartItems = SessionHelper.GetObjectFromJson<List<Item>>(session, CartConstants.Cart);

            foreach(var item in cartItems)
            {
                await _itemService.CreateAsync(item.ProductId, item.Quantity, newDbCartId);
            }
        }

        private async Task<string> CreateCart(Customer cartCustomer)
        {
            var cart = new Cart();
            cart.CustomerId = cartCustomer.Id;

            await this.Repository.AddAsync(cart);
            await this.Repository.SaveChangesAsync();

            // Create Bidirectional relation
            cartCustomer.CartId = cart.Id;
            await this.UserManager.UpdateAsync(cartCustomer);

            return cart.Id;
        }

        private async Task DeletePersistedCart(Cart persistedCart)
        {
            List<Item> persistedItems = (await _itemService.AllByCartIdAsync(persistedCart.Id)).ToList();
            
            foreach (var item in persistedItems)
            {
                await _itemService.DeleteAsync(item);
            }

            this.Repository.Delete(persistedCart);
            await this.Repository.SaveChangesAsync();
        }

        public async Task DeletePersistedCartByCustomerId(string customerId)
        {
            var cart = this.GetCartEntityByCustomerId(customerId);
            await this.DeletePersistedCart(cart);
        }

        private Cart FindByUsername(string username)
        {
            return this.Repository.All()
                .Where(c => c.Customer.UserName == username).FirstOrDefault();
        }

        public void ClearSessionCart(ISession session)
        {
            SessionHelper.SetObjectAsJson(session, CartConstants.Cart, null);
            SessionHelper.SetObjectAsJson(session, CartConstants.ProductCount, 0);
        }

        public async Task<int> GetPersistedCartProductCountAsync(string username, ISession session)
        {
            var cart = FindByUsername(username);

            if (cart == null)
            {
                return 0;
            }

            var cartItems = await _itemService.AllByCartIdAsync(cart.Id);

            int productCount = 0;

            foreach (var item in cartItems)
            {
                productCount += item.Quantity;
            }

            return productCount;
        }

        public async Task ManageCartOnCustomerLoginAsync(ISession session, string username)
        {
            var cartFromSession = SessionHelper.GetObjectFromJson<List<Item>>(session, CartConstants.Cart);
            if (cartFromSession != null)
            {
                await MigrateSessionProductsAsync(username, session);
            }
            else
            {
                int productCount = await GetPersistedCartProductCountAsync(username, session);

                if (productCount != 0)
                {
                    SessionHelper.SetObjectAsJson(session, CartConstants.ProductCount, productCount);

                    var persistedCart = FindByUsername(username);
                    var persistedItems = await _itemService.AllByCartIdAsync(persistedCart.Id);

                    if (persistedItems != null)
                    {
                        AddItemsToSession(persistedItems.ToList(), session);
                    }
                }
            }
        }

        public CartViewModel GetCartViewModelByCustomerId(string customerId)
        {
            var cartViewModel = new CartViewModel();
            Cart cart = this.GetCartEntityByCustomerId(customerId);

            if (cart != null)
            {
                cartViewModel.Items = _itemService
                    .AllViewModelsByCartIdAsync(cart.Id).ToList();
            }

            if (cartViewModel.Items != null)
            {
                foreach (var item in cartViewModel.Items)
                {
                    cartViewModel.Price += (item.Product.Price * item.ProductQuantity);
                }
            }

            return cartViewModel;
        }

        private Cart GetCartEntityByCustomerId(string customerId)
        {
            return Repository.All()
                .Where(c => c.CustomerId == customerId).FirstOrDefault();
        }

        public async Task RemoveItemFromCartAsync(string productId, string customerId, ISession session)
        {
            var cart = this.GetCartEntityByCustomerId(customerId);
            await _itemService.DeleteByCartIdAndProductIdAsync(cart.Id, productId);
            await RemoveItemFromSessionAsync(productId, session);
        }

        public async Task RemoveItemFromSessionAsync(string productId, ISession session)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(session, CartConstants.Cart);

            foreach (var item in cart)
            {
                if (item.ProductId == productId)
                {
                    cart.Remove(item);
                    int productCount = SessionHelper.GetObjectFromJson<int>(session, CartConstants.ProductCount);
                    SessionHelper.SetObjectAsJson(session, CartConstants.ProductCount, productCount -= item.Quantity);
                    break;
                }
            }

            SessionHelper.SetObjectAsJson(session, CartConstants.Cart, cart);
        }
    }
}
