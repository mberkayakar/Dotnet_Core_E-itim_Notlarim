using Microsoft.AspNetCore.Mvc;
using ShopApp.Models;
using System;
using System.Collections.Generic;

namespace ShopApp.Controllers
{
    public class HomeController:Controller
    {

        public IActionResult Index()
        {

            #region View E Veri Gönderme 


            // Viewbag
            // Model
            // ViewData 

            // olmak üzere 3 adet veri gönderim methodumuz bulunmaktadır. 
            #endregion


            /*
             
             Görüldüğü üzere viewbag yollarken vievbag . property kullanmamız yeterlidir. 

            view datada ise bu işler değişmektedir. 
             */

            #region Viewbag Örneği

            ViewBag.İSİM = "Berkay";
            ViewBag.Soyisim = "Akar";
            ViewBag.Zaman = DateTime.Now.Hour < 12 ? "Günaydın" : "Tünaydın";
            ViewBag.TARİH = DateTime.Now;

            #endregion

            #region ViewData Örneği 
            var product = new Product { ID = 1, Price = 5000, Description = "ViewDaya ", İSİM = "Viewdata Sample " };

            ViewData["Product"] = product;
            ViewData["Category"] = "Telefonlar";



            #endregion
            return View();
        }
        //8:30
        //public IActionResult Details(int id)
        //{
        //    return View("Detaylar");
        //}

        public IActionResult Details()
        {
            List<Product> ürünler = new List<Product>
            {
                new Product{ID = 1 , İSİM = "Samsung Galaxy S20 Fan Edition (256/8)" , Description =" En yeni nesil Samsung un 256 lık modeli " , Price = 5500},

                new Product{ID = 2 , İSİM = "iPHONE 5S (128/ROSEGOLD)" , Description =" En yeni nesil İPHONE modeli " , Price = 3000}
            };

            return View("UrunDetay",ürünler);
        }
    }
}
