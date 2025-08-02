using BLL;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret_Prjesi_AHMT.ViewComponents.Shop
{
    public class SeiectSideBarViewComponentPartial : ViewComponent
    {
        private readonly ProductService productServise;

        public SeiectSideBarViewComponentPartial(ProductService product)
        {
            productServise = product;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await productServise.GetallAsync());
        }
    }
}
