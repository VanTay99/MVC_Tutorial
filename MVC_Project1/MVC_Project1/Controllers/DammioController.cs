using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project1.Controllers
{
    public class DammioController : Controller
    {
        // GET: Dammio
        public ActionResult Index()
        {
            return View(); 
        }
       // GET: Hello
       public ActionResult Hello(string name , int numTimes = 5 )
        {
            ViewBag.Message = "Hello" + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
        //Get: /Dammio/ChaoMung/
        public string ChaoMung(string ten,int tuoi=1)
        {
            return HttpUtility.HtmlEncode("Xin chào " + ten + ". Tuổi của bạn là: " + tuoi);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login() 
        {
            ViewBag.Message = "Login Page";

            return View();
        }
        public ActionResult Categories()
        {
            ViewBag.Message = "Categiries Page";
            return View();
        }
  

    }
}