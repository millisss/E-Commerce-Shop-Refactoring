﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingCartStore.Common.BindingModels.Brand;
using ShoppingCartStore.Common.ViewModels.Brand;
using ShoppingCartStore.Data.Common.Repositories;
using ShoppingCartStore.Models;

namespace ShoppingCartStore.Services.DataServices.Implementations
{
    public class BrandService : BaseService<Brand>, IBrandService
    {
        public BrandService(IRepository<Brand> repository, IMapper mapper
            , UserManager<Customer> userManager)
            : base(repository, mapper, userManager)
        {
        }

        public async Task CreateAsync(CreateBrandBindingModel model)
        {
            Brand brand = this.Mapper.Map<Brand>(model);
            await Repository.AddAsync(brand);
            await Repository.SaveChangesAsync();
        }

        public ICollection<BrandViewModel> All()
        {
            return Mapper.Map<ICollection<BrandViewModel>>(Repository.All());
        }

        public List<SelectListItem> AllSelectListItems()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();

            foreach (var brand in this.Repository.All())
            {
                selectListItems.Add(new SelectListItem()
                {
                    Value = brand.Id,
                    Text = brand.Name,
                    Selected = false
                });
            }

            selectListItems.Add(new SelectListItem()
            {
                Value = "",
                Text = "All",
                Selected = true
            });

            return selectListItems;
        }
    }
}
