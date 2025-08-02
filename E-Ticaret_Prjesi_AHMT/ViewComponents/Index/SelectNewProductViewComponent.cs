using BLL;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret_Prjesi_AHMT.ViewComponents.Index
{
    public class SelectNewProductViewComponent : ViewComponent
    {
        private readonly ProductService productServise;

        public SelectNewProductViewComponent(ProductService product)
        {
            productServise = product;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await productServise.GetallAsync());
        }
    }
}
