using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Project1.Models
{
    public class Product
    {
        //Mã sản phẩm
        public string Id { get; set; }
        //Loại sản phẩm
        public string brand { get; set; }
        //Tên sản phẩm
        public string name { get; set; }
        public string lname { get; set; }
        //Hình Ảnh minh họa
        public string url { get; set; }
        //Gía Sản phẩm
        public int Price { get; set; }
        //Thông tin sản phẩm
        public string Description { get; set; }
        public int valueRating { get; set; }
       
        
        
    }
}