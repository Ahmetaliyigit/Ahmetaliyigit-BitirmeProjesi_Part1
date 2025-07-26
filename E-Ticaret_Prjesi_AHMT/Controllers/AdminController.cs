using BLL;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using WebUI.Services;
using System.Diagnostics;

namespace E_Ticaret_Prjesi_AHMT.Controllers
{
    public class AdminController : Controller
    {
        private readonly ProductServise productservise = new ProductServise();
        private readonly ColorService colorService = new ColorService();
        private readonly CategoryService category = new CategoryService();
        private readonly GenderService gender = new GenderService();

        public async Task<IActionResult> CreateProduct()
        {
            ViewBag.Color = await colorService.GetColorsAsync();
            ViewBag.Category = await category.GetCategoriesAsync();
            ViewBag.Gender = await gender.GetGendersAsync();
            return View(new Product());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProduct(Product model , IFormFile ProductImage)
        {
            if (!ModelState.IsValid)
            {
                foreach (var state in ModelState)
                {
                    foreach (var error in state.Value.Errors)
                    {
                        Debug.WriteLine($"HATA: {state.Key} - {error.ErrorMessage}");
                    }
                }
            }

            ModelState.Remove("ProductImage");

            if (ModelState.IsValid)
            {
                if (ProductImage != null)
                {
                    model.Url = await ImageOperations.UploadImageAsync(ProductImage);
                }

               
                await productservise.AddProductAsync(model);
                return RedirectToAction("Index", "Home");
            }

            // HATA VARSA: Kategorileri tekrar ViewBag'e koy    
            ViewBag.Category = await category.GetCategoriesAsync();
            ViewBag.Color = await colorService.GetColorsAsync();
            ViewBag.Gender = await gender.GetGendersAsync();

            return View(model);
        }
    }
}
