using BLL;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret_Prjesi_AHMT.ViewComponents
{
    public class SelectDetailColorSizeViewComponent: ViewComponent
    {
        private readonly ProductService servise;
        private readonly ColorService color;

        public SelectDetailColorSizeViewComponent(ProductService product , ColorService colorService)
        {
            servise = product;
            color = colorService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int Id)
        {
            
            var Product = await servise.GetallAsync(i => i.Id == Id);
            var Colors = await color.GetColorsAsync(i => i.Id == Product.FirstOrDefault().ColorId);
            ViewBag.Color = Colors.FirstOrDefault().ColorName;
            return View(Product.FirstOrDefault());
        }
    }
}
