using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.IO;

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
        public  ProductService.ProductDTOResponse getProducts(int PageSize, int PageIndex)
        {

            var getProducts = _svcProduct.GetProducts(PageSize, PageIndex);
         
            return getProducts;

        }
        #endregion

        #region Search Product
        public  ProductService.ProductDTOResponse searchProduct(int PageSize, int PageIndex, string keyword, double minPrice, double maxPrice)
        {
            var getProducts = _svcProduct.SearchProducts(PageSize, PageIndex, keyword, minPrice, maxPrice);
            return getProducts;
        }
        #endregion
        #region Get Product by Id
        public  ProductService.ProductDTO GetproductByID(int ProductId)
        {
            var GetproductByID = _svcProduct.GetProductById(ProductId);
            return GetproductByID;
        }
        #endregion

        #region Rendertostring
        public static string RenderViewToString(ControllerContext context, string viewPath, object model = null, bool partial = false)
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
    }
}
