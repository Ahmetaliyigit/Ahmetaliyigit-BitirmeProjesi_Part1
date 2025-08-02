using BLL;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret_Prjesi_AHMT.ViewComponents.ShoppingCart
{
    public class SelectShoppingCartViewComponentPartial : ViewComponent
    {
        private readonly ProductService servise;

        public SelectShoppingCartViewComponentPartial(ProductService productServise)
        {
            servise =  productServise;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.Toplamtutar = 0;
            return View(await servise.GetallAsync());
        }
    }
}
