﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartStore.Common.BindingModels.Product;
using ShoppingCartStore.Common.Constants;
using ShoppingCartStore.Common.ViewModels.Product;
using ShoppingCartStore.Services.DataServices;

namespace SoppingCartStore.Web.Controllers
{
    public class ProductsController : Controller
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(FilterBindingModel model)
        {
            IEnumerable<ProductViewModel> products;

            // TODO: Encapsulate business logic in service layer
            if (model.CategoryIdFilter != null || model.BrandIdFilter != null 
                || model.SearchFilter != null)
            {
                products = _productService.GetAllViewModelsFilteredAsync(model);
            }
            else
            {
                products = _productService.GetAllViewModelsAsync();
            }

            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductBindingModel model)
        {
            await _productService.CreateAsync(model);
            return this.RedirectToAction(ActionConstants.Index, ControllerConstants.Products);
        }

        public async Task<IActionResult> Details(string id)
        {
            var productViewModel = _productService.FindById(id);
            return View(productViewModel);
        }
    }
}