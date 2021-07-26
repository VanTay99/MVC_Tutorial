using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project1.Controllers
{
   
    public class DetailController : HomeShopController
    {
        #region router page detail-product
        public ActionResult ViewDetail(string Url, string Id)
        {
            if (string.IsNullOrEmpty(Id)) return null;
            
            var getAll = Bussiness.ServicePproduct.getProducts(11, 0);
         
            var lst = getAll.ListProducts;
            if (lst == null || getAll.Total == 0) return null;

            var obj = lst.FirstOrDefault(p => p != null && p.Id.Equals(Id) && p.Url.Equals(Url));
            if (obj == null) return null;

            return View(obj);
        }
        #endregion

    }


}