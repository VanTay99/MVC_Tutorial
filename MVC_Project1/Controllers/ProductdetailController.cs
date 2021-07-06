using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Project1.Models;
namespace MVC_Project1.Controllers
{
    public class ProductdetailController : Controller
    {
        // GET: Productdetail
        public ActionResult Productdetail()
        {
            var Iphonex = new Product() { name = "IPhone X", lname ="iphone-x",Price=17000000,RatingValue=100,img= "~/Content/Images/iphone-12-pro-max.jpg" };
            return View(Iphonex);
        }
    }
}