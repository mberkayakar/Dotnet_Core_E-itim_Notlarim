using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP_NET_WEB_APP_İNTRO.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
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


    }

    public class Employee
    {
        public int ID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }


    }
}
