using Microsoft.AspNetCore.Mvc;
using WebStore.Interfaces.Services;
using WebStore.ViewModels;

namespace WebStore.Components
{
    public class BreadCrumbsViewComponent : ViewComponent
    {
        private readonly IProductData _ProductData;

        public BreadCrumbsViewComponent(IProductData ProductData) => _ProductData = ProductData;

        public IViewComponentResult Invoke()
        {
            var model = new BreadCrumbsViewModel();

            if (int.TryParse(Request.Query["SectionId"], out var section_id))
            {
                model.Section = _ProductData.GetSection(section_id);
                if (model.Section?.ParentId is { } parent_section_id)
                    model.Section.Parent = _ProductData.GetSection(parent_section_id);
            }

            if (int.TryParse(Request.Query["BrandId"], out var brand_id))
                model.Brand = _ProductData.GetBrand(brand_id);

            if (int.TryParse(ViewContext.RouteData.Values["id"]?.ToString(), out var product_id))
                model.Product = _ProductData.GetProductById(product_id)?.Name;

            return View(model);
        }
    }
}