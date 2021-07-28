using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bussiness;
namespace MVC_Project1.Controllers
{
   
    public class DetailController : HomeShopController
    {
        #region detail-product
        public ActionResult ViewDetail(string Url, int Id)
        {

          
            if (string.IsNullOrEmpty(Id.ToString())) return null;
            
            var obj = ServiceProduct.Instance.getproductByID(Id);
         
           
            if ( obj == null) return View("~Views/HomeShop/ViewProduct.cshtml");
            if(obj.Url!=Url)
            {
                return RedirectToAction("ViewDetail", "Detail", new { url = obj.Url, id = obj.Id });
            }

            return View(obj);
        }
        #endregion

    }


}