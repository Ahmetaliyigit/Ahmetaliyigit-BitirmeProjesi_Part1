using BLL;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using WebUI.Services;
using System.Diagnostics;
using Mono.TextTemplating;

namespace E_Ticaret_Prjesi_AHMT.Controllers
{
    public class AdminController : Controller
    {
        private readonly ProductService productservise;
        private readonly ColorService colorService;
        private readonly CategoryService category;
        private readonly GenderService gender;
        public AdminController(ProductService servise,ColorService color,CategoryService categoryservice,GenderService genderservice)
        {
            productservise = servise;
            colorService = color;
            category = categoryservice;
            gender = genderservice;
        }

      

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
     
            ModelState.Remove("ProductImage");
            ModelState.Remove("Color");
            ModelState.Remove("Gender");
            ModelState.Remove("Category");
            ModelState.Remove("Url");
            ModelState.Remove("Name");    
            ModelState.Remove("Size");    


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

            Debug.WriteLine(model.Description+" Bu descriprion");

            if (ModelState.IsValid)
            {
                if (ProductImage != null)
                {
                    model.Url = await ImageOperations.UploadImageAsync(ProductImage);
                }

               
                await productservise.AddProductAsync(model);
                return RedirectToAction("Index", "Home");
            }

            

            ViewBag.Category = await category.GetCategoriesAsync();
            ViewBag.Color = await colorService.GetColorsAsync();
            ViewBag.Gender = await gender.GetGendersAsync();

            return View(model);
        }
    }
}
