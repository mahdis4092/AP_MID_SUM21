using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ProductController : ApiController
    {
        [Route("api/Product/GetAll")]
        public List<ProductModel> GetAllProducts()
        {
            return ProductService.GetAllProducts();
        }
        [Route("api/Product/{id}")]
        public ProductModel GetProduct(int id)
        {
            return ProductService.GetProduct(id);
        }
        [Route("api/Product/Add")]
        [HttpPost]
         public void AddProduct(ProductModel model)
         {
             ProductService.AddProduct(model);
         }
        //[HttpPost]
      /*  public void Add(ProductModel pt)
        {
            ProductService.AddProduct(pt);
        }*/

    }
}
