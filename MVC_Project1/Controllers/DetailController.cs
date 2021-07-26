using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project1.Controllers
{
   
    public class DetailController : HomeShopController
    {
        #region router page detail-productB
        public ActionResult ViewDetail(string Url, int Id)
        {

          
            if (string.IsNullOrEmpty(Id.ToString())) return null;
            
            var getproductbyId = Bussiness.ServicePproduct.GetproductByID(Id);
         
           
            if (getproductbyId.Id != Id || getproductbyId == null) return null;

            return View(getproductbyId);
        }
        #endregion

    }


}