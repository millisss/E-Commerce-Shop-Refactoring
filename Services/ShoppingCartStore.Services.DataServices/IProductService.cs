﻿namespace ShoppingCartStore.Services.DataServices
{
    using ShoppingCartStore.Common.BindingModels.Product;
    using ShoppingCartStore.Common.ServiceModels.Wishlist;
    using ShoppingCartStore.Common.ViewModels.Product;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IProductService
    {
        Task CreateAsync(CreateProductBindingModel model);

        ICollection<ProductViewModel> GetAllViewModelsFilteredAsync(FilterBindingModel filterBindingModel);

        ICollection<ProductViewModel> GetAllViewModelsAsync();

        ProductViewModel FindById(string id);
    }
}
