using BLL;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret_Prjesi_AHMT.ViewComponents.Index
{
    public class SelectTop4ProductViewComponentPartial : ViewComponent
    {
        private readonly ProductServise productservise;

        public SelectTop4ProductViewComponentPartial()
        {
            productservise = new ProductServise();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await productservise.GetallAsync());
        }
    }
}
