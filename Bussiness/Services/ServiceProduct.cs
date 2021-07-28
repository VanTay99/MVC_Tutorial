using System.IO;
using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;


namespace Bussiness
{
    public class ServiceProduct
    {
        private static ServiceProduct _instance;
        private readonly ProductService.ProductSvc _svcProduct;
        public static ServiceProduct Instance
        {
            get { return _instance ?? (_instance = new ServiceProduct()); }
        }
        private ServiceProduct()
        {
            _svcProduct = new ProductService.ProductSvc();
        }
        #region Get Product PageSize and PageIndex
        public ProductService.ProductDTOResponse getProducts(int PageSize, int PageIndex)
        {

            var getProducts = _svcProduct.GetProducts(PageSize, PageIndex);

            return getProducts;

        }
        #endregion

        #region Search Product
        public ProductService.ProductDTOResponse searchProduct(int PageSize, int PageIndex, string keyword, double minPrice, double maxPrice)
        {
            var getProducts = _svcProduct.SearchProducts(PageSize, PageIndex, keyword, minPrice, maxPrice);
            return getProducts;
        }
        #endregion
        #region Get Product by Id
        public ProductService.ProductDTO getproductByID(int ProductId)
        {
            var GetproductByID = _svcProduct.GetProductById(ProductId);
            return GetproductByID;
        }
        #endregion

        
    }
}
