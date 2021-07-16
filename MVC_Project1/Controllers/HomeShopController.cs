using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Project1.Models;
namespace MVC_Project1.Controllers
{
    public class HomeShopController : Controller
    {
        // GET: HomeShop
       
        public ActionResult Index()
        {
            return View();
        }
        
       

        public ActionResult ViewProduct()
        {
            var products = GetListProducts();
            return View(products);
        }


        // GET: Product/detail ->  Redirecto to Home page

        /// <summary>
        /// Lấy ds sản phẩ trang chủ ...
        /// </summary>
        /// <returns></returns>
        public List<Product> GetListProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id="1",
                    brand="Apple",
                    name="Iphone 12 Pro Max ",
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
                }

            };
            return products;
        }
        #region Demo partialview (footer)
        public ActionResult DemoPartialviewfooter()
        {
            return PartialView();
        }
        #endregion
    }
}
