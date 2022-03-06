using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_WEB_APP_İNTRO.Controllers
{
    public class SessionDemoController:Controller
    {
    

        public string index1() 
        {

            HttpContext.Session.SetString("isim", "Engin");

 
            return HttpContext.Session.GetString("isim");
        }



        public string index2() 
        {
            return HttpContext.Session.GetString("isim");
        }



    }
}
