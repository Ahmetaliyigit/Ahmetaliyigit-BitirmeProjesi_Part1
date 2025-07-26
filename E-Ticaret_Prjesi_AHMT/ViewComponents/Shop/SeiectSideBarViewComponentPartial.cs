using BLL;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret_Prjesi_AHMT.ViewComponents.Shop
{
    public class SeiectSideBarViewComponentPartial : ViewComponent
    {
        private readonly ProductServise productServise;

        public SeiectSideBarViewComponentPartial()
        {
            productServise = new ProductServise();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await productServise.GetallAsync());
        }
    }
}
