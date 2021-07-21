using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Project1.Models;
namespace MVC_Project1.Controllers
{
    public class HomeShopController : Controller
    {
        private const int PageSize = 5;

        #region Demo
        public ActionResult Index()
        {
            return View();
        }
        #endregion


        #region Hiển Thị danh sách sản phẩm
        public ActionResult ViewProduct()
        {
            var SumProduct = GetListProducts();
            return View(SumProduct.Take(PageSize));


        }
        #endregion


        #region Hiển thị View Dưới dạng chuỗi
        static string RenderViewToString(ControllerContext context, string viewPath, object model = null, bool partial = false)
        {
            // first find the ViewEngine for this view
            ViewEngineResult viewEngineResult = null;
            if (partial)
                viewEngineResult = ViewEngines.Engines.FindPartialView(context, viewPath);
            else
                viewEngineResult = ViewEngines.Engines.FindView(context, viewPath, null);

            if (viewEngineResult == null)
                throw new FileNotFoundException("View cannot be found.");

            // get the view and attach the model to view data
            var view = viewEngineResult.View;
            context.Controller.ViewData.Model = model;

            string result = null;

            using (var sw = new StringWriter())
            {
                var ctx = new ViewContext(context, view, context.Controller.ViewData, context.Controller.TempData, sw);
                view.Render(ctx, sw);
                result = sw.ToString();
            }

            return result;
        }
        #endregion

        #region return partial view ListProduct with list product by remain.
        public ActionResult fetchData(int PageIndex)
        {
            var SumProduct = GetListProducts();
            //Lay cac san pham tiep theo bo qua so san pham da hien thi
            var products = SumProduct.Skip(PageSize * PageIndex).Take(PageSize);
            var remain = SumProduct.Count - PageSize * PageIndex - PageSize;
            var JSON = Json(new
            {
                remain = remain,
                html = RenderViewToString(ControllerContext, "~/Views/HomeShop/ListProduct.cshtml", products, true)
            });
            return JSON;
        }
        #endregion

        #region lấy danh sách sản phẩm
        public List<Product> GetListProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id="1",
                    brand="Apple",
                    name="Iphone 12 Pro Max",
                    url="/Content/desktop/images/iphone12_1.jpg",
                    Price=28950,
                    Description="Máy mới chính hãng Apple Việt Nam",
                    valueRating=4,
                    lname="iphone12"

                },
                new Product
                {
                    Id="2",
                    brand="Apple",
                    name="Iphone 11",
                    url="/Content/desktop/images/iphone11.jpg",
                    Price=14800,
                    Description=" Máy mới chính hãng Apple Việt Nam",
                    valueRating=4,
                    lname="iphone11"
                },
                new Product
                {
                    Id="3",
                    brand="SamSung",
                    name="Samsung Galaxy Note 20 ",
                    url="/Content/desktop/images/galaxynote20.jpg",
                    Price=19950,
                    Description=" Máy mới chính hãng SamSung Việt Nam",
                    valueRating=5,
                    lname="samsunggalaxynote20"
                },
                new Product
                {
                    Id="4",
                    brand="SamSung",
                    name="Samsung Galaxy S20 FE",
                    url="/Content/desktop/images/samsungs20.jpg",
                    Price=12950,
                    Description=" Máy mới chính hãng Samsung Việt Nam",
                    valueRating=5,
                    lname="samsunggalaxys20"
                },
                new Product
                {
                    Id="5",
                    brand="Xiaomi",
                    name="Xaomi Redmi Note 10",
                    url="/Content/desktop/images/xiaominote10.jpg",
                    Price=4950,
                    Description=" Máy mới chính hãng Xiaomi Việt Nam",
                    valueRating=4,
                    lname="xiaomiredminote10"

                },
                new Product
                {
                     Id="6",
                    brand="Xiaomi",
                    name="Xaomi Redmi Note 10 Pro ",
                    url="/Content/desktop/images/xiaominote10pro.jpg",
                    Price=6950,
                    Description=" Máy mới chính hãng Xiaomi Việt Nam",
                    valueRating=4,
                    lname="xiaomiredminote10pro"
                },
                new Product
                {
                    Id="7",
                    brand="ViVo",
                    name="Vivo X60 Pro 5G",
                    url="/Content/desktop/images/vivo-x60-pro-8.jpg",
                    Price=14950,
                    Description=" Máy mới chính hãng ViVo Việt Nam",
                    valueRating=4,
                    lname="vivox60pro5g"
                },
                new Product
                {
                    Id="8",
                    brand="ViVo",
                    name="ViVo V21 5G",
                    url="/Content/desktop/images/vivo-v21-600x600.jpg",
                    Price=8950,
                    Description=" Máy mới chính hãng ViVo Việt Nam",
                    valueRating=5,
                    lname="vivov215g"
                },
                new Product
                {
                    Id="9",
                    brand="Oppo",
                    name="Oppo Reno 5",
                    url="/Content/desktop/images/opporeno5.jpg",
                    Price=8950,
                    Description=" Máy mới chính hãng Oppo Việt Nam",
                    valueRating=4,
                    lname="opporeno5"
                },
                new Product
                {
                    Id="10",
                    brand="Oppo",
                    name="Oppo A93",
                    url="/Content/desktop/images/oppoA93.jpg",
                    Price=28950,
                    Description=" Máy mới chính hãng Oppo Việt Nam",
                    valueRating=5,
                    lname="oppoa93"
                },
                 new Product
                {
                    Id="11",
                    brand="Apple",
                    name="Iphone 12 Pro Max",
                    url="/Content/desktop/images/iphone12_1.jpg",
                    Price=28950,
                    Description="Máy mới chính hãng Apple Việt Nam",
                    valueRating=4,
                    lname="iphone12"

                },
                new Product
                {
                    Id="12",
                    brand="Apple",
                    name="Iphone 11",
                    url="/Content/desktop/images/iphone11.jpg",
                    Price=14800,
                    Description=" Máy mới chính hãng Apple Việt Nam",
                    valueRating=4,
                    lname="iphone11"
                },
                new Product
                {
                    Id="13",
                    brand="SamSung",
                    name="Samsung Galaxy Note 20 ",
                    url="/Content/desktop/images/galaxynote20.jpg",
                    Price=19950,
                    Description=" Máy mới chính hãng SamSung Việt Nam",
                    valueRating=5,
                    lname="samsunggalaxynote20"
                },
                new Product
                {
                    Id="14",
                    brand="SamSung",
                    name="Samsung Galaxy S20 FE",
                    url="/Content/desktop/images/samsungs20.jpg",
                    Price=12950,
                    Description=" Máy mới chính hãng Samsung Việt Nam",
                    valueRating=5,
                    lname="samsunggalaxys20"
                },
                new Product
                {
                    Id="15",
                    brand="Xiaomi",
                    name="Xaomi Redmi Note 10",
                    url="/Content/desktop/images/xiaominote10.jpg",
                    Price=4950,
                    Description=" Máy mới chính hãng Xiaomi Việt Nam",
                    valueRating=4,
                    lname="xiaomiredminote10"

                },
                new Product
                {
                     Id="16",
                    brand="Xiaomi",
                    name="Xaomi Redmi Note 10 Pro ",
                    url="/Content/desktop/images/xiaominote10pro.jpg",
                    Price=6950,
                    Description=" Máy mới chính hãng Xiaomi Việt Nam",
                    valueRating=4,
                    lname="xiaomiredminote10pro"
                },
                new Product
                {
                    Id="17",
                    brand="ViVo",
                    name="Vivo X60 Pro 5G",
                    url="/Content/desktop/images/vivo-x60-pro-8.jpg",
                    Price=14950,
                    Description=" Máy mới chính hãng ViVo Việt Nam",
                    valueRating=4,
                    lname="vivox60pro5g"
                },
                new Product
                {
                    Id="18",
                    brand="ViVo",
                    name="ViVo V21 5G",
                    url="/Content/desktop/images/vivo-v21-600x600.jpg",
                    Price=8950,
                    Description=" Máy mới chính hãng ViVo Việt Nam",
                    valueRating=5,
                    lname="vivov215g"
                },
                new Product
                {
                    Id="19",
                    brand="Oppo",
                    name="Oppo Reno 5",
                    url="/Content/desktop/images/opporeno5.jpg",
                    Price=8950,
                    Description=" Máy mới chính hãng Oppo Việt Nam",
                    valueRating=4,
                    lname="opporeno5"
                },
                new Product
                {
                    Id="20",
                    brand="Oppo",
                    name="Oppo A93",
                    url="/Content/desktop/images/oppoA93.jpg",
                    Price=28950,
                    Description=" Máy mới chính hãng Oppo Việt Nam",
                    valueRating=5,
                    lname="oppoa93"
                }
            };
            return products;
        }
        #endregion
        
        #region Demo partialview (footer)
        public ActionResult DemoPartialviewfooter()
        {
            return PartialView();
        }
        #endregion
    }
}