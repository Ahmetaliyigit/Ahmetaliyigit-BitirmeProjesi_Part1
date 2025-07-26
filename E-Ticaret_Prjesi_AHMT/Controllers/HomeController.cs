using System.Diagnostics;
using System.Drawing;
using BLL;
using E_Ticaret_Prjesi_AHMT.Models;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret_Prjesi_AHMT.Controllers
{
    public class HomeController : Controller
    {

        public int UserId2{ get; set; } = 25;

        private readonly ProductServise productservise;
        

        public HomeController()
        {
            productservise = new ProductServise();
          
        }

        public async Task<IActionResult> Index()
        {            
            return View();
        }

        public async Task<IActionResult> Shop(int Id) 
        {
            ViewBag.Id = Id;
            return View(await productservise.GetallAsync());
        }

        public async Task<IActionResult> ShopDetails(int Id)
        {
            var detail = await productservise.GetallAsync(i => i.Id == Id);
            return View(detail.FirstOrDefault());
        }

        public async Task<IActionResult> ShoppingCart()
        {
            ViewBag.Toplamtutar = 0;
            return View(await productservise.GetallAsync());
        }

        public async Task<IActionResult> Checkout()
        {
            return View();
        }

        public async Task<IActionResult> ContactUs()
        {
            return View();
        }

        public async Task<IActionResult> LoginRegister()
        {
            return View();
        }
    }
}
