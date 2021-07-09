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
       
        public List<Product> GetListProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id="1",
                    brand="Apple",
                    name="Iphone 12 Pro Max| Chính Hãng VN/A",
                    url="/Content/Images/iphone12Promax.jpg",
                    Price=28950,
                    Description="Máy mới chính hãng Apple Việt Nam"

                },
                new Product
                {
                    Id="2",
                    brand="Apple",
                    name="Iphone 11 | Chính Hãng VN/A",
                    url="/Content/Images/iphone11.jpg",
                    Price=14800,
                    Description=" Máy mới chính hãng Apple Việt Nam"
                },
                new Product
                {
                    Id="3",
                    brand="SamSung",
                    name="Samsung Galaxy Note 20 Ultra 5G",
                    url="/Content/Images/samsunggalaxynote20.jpg",
                    Price=19950,
                    Description=" Máy mới chính hãng SamSung Việt Nam"
                },
                new Product
                {
                    Id="4",
                    brand="SamSung",
                    name="Samsung Galaxy S20 FE 256GB(FAN Edition",
                    url="/Content/Images/samsungs20.jpg",
                    Price=12950,
                    Description=" Máy mới chính hãng Samsung Việt Nam"
                },
                new Product
                {
                    Id="5",
                    brand="Xiaomi",
                    name="Xaomi Redmi Note 10",
                    url="/Content/Images/xiaomi-note10.jpg",
                    Price=4950,
                    Description=" Máy mới chính hãng Xiaomi Việt Nam"
                },
                new Product
                {
                     Id="6",
                    brand="Xiaomi",
                    name="Xaomi Redmi Note 10 Pro 8GB",
                    url="/Content/Images/xiaominote10pro_.jpg",
                    Price=6950,
                    Description=" Máy mới chính hãng Xiaomi Việt Nam"
                },
                new Product
                {
                    Id="7",
                    brand="ViVo",
                    name="Vivo X60 Pro 5G",
                    url="/Content/Images/vivo-x60-pro-8.jpg",
                    Price=14950,
                    Description=" Máy mới chính hãng ViVo Việt Nam"
                },
                new Product
                {
                    Id="8",
                    brand="ViVo",
                    name="ViVo V21 5G",
                    url="/Content/Images/vivo-v21-5g-2.jpg",
                    Price=8950,
                    Description=" Máy mới chính hãng ViVo Việt Nam"
                },
                new Product
                {
                    Id="9",
                    brand="Oppo",
                    name="Oppo Reno 5",
                    url="/Content/Images/oppo-reno-5_3_.jpg",
                    Price=8950,
                    Description=" Máy mới chính hãng Oppo Việt Nam"
                },
                new Product
                {
                    Id="10",
                    brand="Oppo",
                    name="Oppo A93",
                    url="/Content/Images/oppoA93.png",
                    Price=28950,
                    Description=" Máy mới chính hãng Oppo Việt Nam"
                }

            };
            return products;
        }
    }
}