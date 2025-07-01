using BLL;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret_Prjesi_AHMT.ViewComponents.Brand
{
    public class SelectProductViewComponentPartial : ViewComponent
    {
        private readonly ProductServise productservise;

        public SelectProductViewComponentPartial()
        {
            productservise = new ProductServise();
        }

        public async Task<IViewComponentResult> InvokeAsync(int Id)
        {
            if (Id == 1)
            {
                return View(await productservise.GetallAsync(i => i.GenderId == 1));
            }  // Erkek olanları çağır
            else if (Id == 2)
            {
                return View(await productservise.GetallAsync(i => i.GenderId == 2));
            }  // Kadın olanları çağır
            else if (Id == 3)
            {
                return View(await productservise.GetallAsync(i => i.GenderId == 3));
            } // Çocuk olanları çağır
            else if (Id == 18)
            {
                return View(await productservise.GetallAsync(i => i.CategoryId == 11));
            }// Aksesuarları çağır
            else if (Id == 12)
            {
                return View(await productservise.GetallAsync(i => i.CategoryId == 12));
            }// Çantaları çağır
            else if (Id == 10)
            {
                return View(await productservise.GetallAsync(i => i.CategoryId == 10));
            } // Ayakkabıları  çağır
            else if (Id == 999)
            {
                return View(await productservise.GetallAsync(i => i.Price > 0 && i.Price < 100));
            } //  0 - 100
            else if (Id == 998)
            {
                return View(await productservise.GetallAsync(i => i.Price > 100 && i.Price < 200));
            }// 100 - 200
            else if (Id == 997)
            {
                return View(await productservise.GetallAsync(i => i.Price > 200 && i.Price < 300));
            }// 200 - 300
            else if (Id == 996)
            {
                return View(await productservise.GetallAsync(i => i.Price > 300 && i.Price < 400));
            } // 300 - 400
            else if (Id == 995)
            {
                return View(await productservise.GetallAsync(i => i.Price > 400 && i.Price < 500));
            }// 400 - 500
            else if (Id == 11)
            {
                return View(await productservise.GetallAsync(i => i.ColorId == 1));
            }// Siyah olanları çağır
            else if (Id == 22)
            {
                return View(await productservise.GetallAsync(i => i.ColorId == 2));
            } // Beyaz olanları çağır
            else if (Id == 33)
            {
                return View(await productservise.GetallAsync(i => i.ColorId == 3));
            }// Kırmızı olanları çağır
            else if (Id == 44)
            {
                return View(await productservise.GetallAsync(i => i.ColorId == 4));
            } // Mavi olanları çağır
            else if (Id == 55)
            {
                return View(await productservise.GetallAsync(i => i.ColorId == 5));
            }// Yeşil olanları çağır
            else if (Id == 23)
            {
                return View(await productservise.GetallAsync(i => i.Size == "XS"));
            } // XS olanları çağır
            else if (Id == 34)
            {
                return View(await productservise.GetallAsync(i => i.Size == "S"));
            }// S olanları çağır  
            else if (Id == 45)
            {
                return View(await productservise.GetallAsync(i => i.Size == "M"));
            } // M olanları çağır
            else if (Id == 56)
            {
                return View(await productservise.GetallAsync(i => i.Size == "L"));
            }// L olanları çağır
            else if (Id == 67)
            {
                return View(await productservise.GetallAsync(i => i.Size == "XL"));
            }// XL olanları çağır
            else if (Id == 109)
            {
                return View(await productservise.GetallAsync(i => i.CategoryId == 1 && i.GenderId == 1));
            } // Erkek Elbiseleri çağır
            else if (Id == 110)
            {
                return View(await productservise.GetallAsync(i => i.CategoryId == 1 && i.GenderId == 2));
            }// Kadın Elbiseleri çağır
            else if (Id == 111)
            {
                return View(await productservise.GetallAsync(i => i.CategoryId == 1 && i.GenderId == 3));
            }// Çocuk elbiseleri
            else if (Id == 100)
            {
                return View(await productservise.GetallAsync(i => i.CategoryId == 2));
            }// Shirts
            else if (Id == 101)
            {
                return View(await productservise.GetallAsync(i => i.CategoryId == 3));
            }// Jeans
            else if (Id == 102)
            {
                return View(await productservise.GetallAsync(i => i.CategoryId == 4));
            }// Swimwear
            else if (Id == 103)
            {
                return View(await productservise.GetallAsync(i => i.CategoryId == 5));
            }// Sleepwear
            else if (Id == 104)
            {
                return View(await productservise.GetallAsync(i => i.CategoryId == 6));
            }// Sportswear
            else if (Id == 105)
            {
                return View(await productservise.GetallAsync(i => i.CategoryId == 7));
            }// Jumpsuits
            else if (Id == 106)
            {
                return View(await productservise.GetallAsync(i => i.CategoryId == 8));
            }// Blazers
            else if (Id == 107)
            {
                return View(await productservise.GetallAsync(i => i.CategoryId == 9));
            }// Jackets
            else
            {
                return View(await productservise.GetallAsync());
            } // Alayını çağır
        }
    }
}
