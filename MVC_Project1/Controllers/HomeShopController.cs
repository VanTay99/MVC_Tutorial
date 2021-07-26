using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bussiness;

namespace MVC_Project1.Controllers
{
    public class HomeShopController : Controller
    {
        private const int PageSize = 5;
        #region fetch data view-more button
        public ActionResult fetchData(int PageIndex, Boolean isSearching, string keyword)
        {
            Bussiness.ProductService.ProductDTOResponse getProducts;
            double minPrice = 0;
            double maxPrice = 10000000;
            if (!isSearching)
            {
                getProducts = Bussiness.ServicePproduct.getProducts(PageSize, PageIndex);
            }
            else
            {
                getProducts = Bussiness.ServicePproduct.searchProduct(PageSize, PageIndex, keyword, minPrice, maxPrice);
            }
            var remain = getProducts.Remain;

            var listProducts = getProducts.ListProducts;
            if (listProducts != null)
            {
                var JSON = Json(new
                {
                    remain = remain,
                    html = Bussiness.ServicePproduct.RenderViewToString(ControllerContext, "~/Views/HomeShop/ListProduct.cshtml", getProducts, true)
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
            double minPrice = 0;
            double maxPrice = 10000000;
            var PageIndex = 0;
            var searchProducts = Bussiness.ServicePproduct.searchProduct(PageSize, PageIndex, search, minPrice, maxPrice);
          


            return View(searchProducts);
        }
        #endregion





    }
}