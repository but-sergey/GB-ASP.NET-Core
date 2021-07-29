﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebStore.Domain.ViewModels;
using WebStore.Interfaces.Services;

namespace WebStore.Components
{
    public class BrandsViewComponent : ViewComponent
    {
        private readonly IProductData _ProductData;

        public BrandsViewComponent(IProductData ProductData) => _ProductData = ProductData;

        public IViewComponentResult Invoke(string BrandId) => View(GetBrands());

        public IEnumerable<BrandsViewModel> GetBrands() =>
            _ProductData.GetBrands()
            .OrderBy(b => b.Order)
            .Select(b => new BrandsViewModel
            {
                Id = b.Id,
                Name = b.Name,
            });
    }
}
