using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ASP_NET_WEB_APP_İNTRO.Entities;
using ASP_NET_WEB_APP_İNTRO.Models;

namespace ASP_NET_WEB_APP_İNTRO.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*   [Route("{Product}/[action]/{yazi}")]*/ // Burada şimdi özel bir route ayarladım ona dedim ki artık sen id alma ona bakma o da tamam dedi. Proje ilkin girdi startupa baktı controller/action/id aradı baktı bu actionda id yok yazi var sonra bizim bu Route girdi. biz yazi yerine yazı yazsaydık yine bulamazdı

        // o zaman böyle işlerde ana routing yerine burada o değişken (id yi yani) değiştirmek istersek her birine özel routing yazacaz

        // bi sonraki fonkisyonda string kullanmak istersem burada bu şekil mi olacak ?  prdn

        //[Route("{Product}/[action]/{yazilar}")]


        public string Indexparametreli(int id)
        {

            var content = "? olarak belirtilen yere girilen yazı : \n \n \n" + id;
            return content;
        }


        [Route("{Product}/[action]/{isim}")]
        public string Indexparametreli(string isim)
        {

            var content = "? olarak belirtilen yere girilen yazı : \n \n \n" + isim;
            return content;
        }


        public IActionResult Indexabc()
        {
            return View("Viewdenemesi");
        }
        public string Index2()
        {
            return "Berkay AKAR";
        }

        public int Index3()
        {
            return 5 * 3 + 2;
        }

        public Employee Index4()
        {

            Employee insan = new Employee();

            insan.ID = 1;
            insan.isim = "Berkay";
            insan.soyisim = "Akar";

            return insan;
        }

        public List<Employee> Index5()
        {
            List<Employee> insanlar = new List<Employee>();

            Employee insan = new Employee();
            insan.ID = 1;
            insan.isim = "Berkay";
            insan.soyisim = "Akar";
            insanlar.Add(insan);


            Employee insan2 = new Employee();
            insan2.ID = 2;
            insan2.isim = "Feyaz";
            insan2.soyisim = "Beğen";
            insanlar.Add(insan2);


            Employee insan3 = new Employee();
            insan3.ID = 3;
            insan3.isim = "Merve";
            insan3.soyisim = "Kervan";

            insanlar.Add(insan3);


            return insanlar;
        }

     
        public IActionResult ahmet()
        {
            List<Product> ürünlerlistesi = new List<Product>
            { 
                new Product {ID = 1 , Ürün_Adı = "Monster " , Ürün_Tipi = "Bilgisayar" , Stok_Miktarı= 20},
                new Product {ID = 2 , Ürün_Adı = "Kettle " , Ürün_Tipi = "Su isiticisi" , Stok_Miktarı= 20},
                new Product {ID = 3 , Ürün_Adı = "S20FE" , Ürün_Tipi = "Cep telefonu" , Stok_Miktarı= 20}
            };

         

            return View("Viewdenemesi", ürünlerlistesi);
        }

        public IActionResult ahmet2()
        {
            List<Product> ürünlerlistesi = new List<Product>
            {
                new Product {ID = 1 , Ürün_Adı = "Monster " , Ürün_Tipi = "Bilgisayar" , Stok_Miktarı= 20},
                new Product {ID = 2 , Ürün_Adı = "Kettle " , Ürün_Tipi = "Su isiticisi" , Stok_Miktarı= 20},
                new Product {ID = 3 , Ürün_Adı = "S20FE" , Ürün_Tipi = "Cep telefonu" , Stok_Miktarı= 20}
            };

            List<Employess> işçilerlistesi = new List<Employess>
            {
                new Employess {ID = 1 , ISIM= "Berkay " , SOYİSİM= "Akar" },
                new Employess {ID = 1 , ISIM= "Feyyaz " , SOYİSİM= "Begen" },
            };


            var modelviewim = new ProductListViewModel();
       
            modelviewim.Products = ürünlerlistesi;


            return View("indexmodel", ürünlerlistesi);
        }

    }

    public class Employee
    {
        public int ID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }


    }
}
