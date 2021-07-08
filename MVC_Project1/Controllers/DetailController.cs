using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project1.Controllers
{
    public class DetailController : HomeShopController
    {
        public ActionResult ViewDetail ( string Id)
        {
            if (string.IsNullOrEmpty(Id)) return null;

            var lst = GetListProducts();
            if (lst == null || lst.Count == 0) return null;

            var obj = lst.FirstOrDefault(p => p != null && p.Id.Equals(Id));
            if (obj == null) return null;
            return View(obj);
        }
       
    }
}