using BLL;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret_Prjesi_AHMT.ViewComponents.Index
{
    public class SelectNewProductViewComponent : ViewComponent
    {
        private readonly ProductServise productServise;

        public SelectNewProductViewComponent()
        {
            productServise = new ProductServise();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await productServise.GetallAsync());
        }
    }
}
