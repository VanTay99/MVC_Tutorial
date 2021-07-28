using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bussiness;
using Bussiness.ProductService;

namespace MVC_Project1.Controllers
{
    public class HomeShopController : Controller
    {
        private const int PageSize = 5;
        #region fetch data view-more button
        public ActionResult fetchData(int PageIndex)
        {
            ProductDTOResponse getProducts;
            getProducts = ServiceProduct.Instance.getProducts(PageSize, PageIndex);

            var listProducts = getProducts.ListProducts;
            if (listProducts != null)
            {
                var JSON = Json(new
                {
                    remain = getProducts.Remain,
                    html = Helper.RenderViewToString(ControllerContext, "~/Views/HomeShop/ListProduct.cshtml", getProducts, true)
                }); ;
                return JSON;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region get and search product
        public ActionResult ViewProduct(string search)
        {
            var PageIndex = 0;
            var searchProducts = ServiceProduct.Instance.getProducts(PageSize, PageIndex);
            if (searchProducts != null)
            {
                return View(searchProducts);
            }
            else return null;
        }
        #endregion





    }
}