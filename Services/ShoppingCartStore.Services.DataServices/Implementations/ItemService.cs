﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using ShoppingCartStore.Common.ViewModels.Item;
using ShoppingCartStore.Data.Common.Repositories;
using ShoppingCartStore.Models;

namespace ShoppingCartStore.Services.DataServices.Implementations
{
    public class ItemService : BaseService<Item>, IItemService
    {
        private IProductService _productService;

        public ItemService(IRepository<Item> repository, IMapper mapper
            , UserManager<Customer> userManager, IProductService productService) 
            : base(repository, mapper, userManager)
        {
            _productService = productService;
        }

        public async Task<Item> CreateAsync(string productId, int quantity, string cartId)
        {
            Item item = new Item();
            item.ProductId = productId;
            item.Quantity = quantity;
            item.CartId = cartId;
            await this.Repository.AddAsync(item);
            await this.Repository.SaveChangesAsync();
            return item;
        }

        public async Task DeleteAsync(Item item)
        {
            this.Repository.Delete(item);
            await this.Repository.SaveChangesAsync();
        }
        
        public async Task<IEnumerable<Item>> AllAsync()
        {
            return this.Repository.All();
        }

        public async Task<IEnumerable<Item>> AllByCartIdAsync(string cartId)
        {
            return Repository.All().Where(i => i.CartId == cartId);
        }

        public async Task<Item> FindByProductIdAsync(string productId)
        {
            return Repository.All().FirstOrDefault(i => i.ProductId == productId);
        }

        public async Task<Item> FindByIdAndCustomerUsername
            (string productId, string username)
        {
            return Repository.All().FirstOrDefault(i => i.ProductId == productId 
                    && i.Cart.Customer.UserName == username);
        }

        public async Task UpdateItemProductQuantityAsync(string itemId, int count)
        {
            var item = this.Repository.FindById(itemId);
            item.Quantity += count;
            this.Repository.Update(item);
            await this.Repository.SaveChangesAsync();
        }

        public ICollection<ItemViewModel> AllViewModelsByCartIdAsync(string cartId)
        {
            var itemViewModels = new List<ItemViewModel>();

            var itemEntities = GetItemEntitiesByCartId(cartId);

            foreach (var itemEntity in itemEntities)
            {
                ItemViewModel itemViewModel = new ItemViewModel();
                itemViewModel.Id = itemEntity.Id;
                var productViewModel = _productService.FindById(itemEntity.ProductId);
                itemViewModel.Product = productViewModel;
                itemViewModel.ProductQuantity = itemEntity.Quantity;
                itemViewModels.Add(itemViewModel);
            }

            return itemViewModels;
        }

        private IEnumerable<Item> GetItemEntitiesByCartId(string cartId)
        {
            return Repository.All().Where(i => i.CartId == cartId);
        }

        public async Task<Item> FindByProductIdAndCustomerUsernameAsync(string productId, string username)
        {
            return Repository.All().FirstOrDefault(i => i.ProductId == productId
                    && i.Cart.Customer.UserName == username);
        }

        public async Task<Item> FindByIdAndCustomerIdAsync(string itemId, string customerId)
        {
            return Repository.All().FirstOrDefault(i => i.Id == itemId
                    && i.Cart.Customer.Id == customerId);
        }

        public async Task DeleteByCartIdAndProductIdAsync(string cartId, string productId)
        {
            var item = FindByCartIdAndProductId(cartId, productId);
            this.Repository.Delete(item);
            await this.Repository.SaveChangesAsync();
        }

        private Item FindByCartIdAndProductId(string cartId, string productId)
        {
            return this.Repository.All()
                .Where(i => i.CartId == cartId && i.ProductId == productId).FirstOrDefault();
        }
    }
}
