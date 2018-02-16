using snkrshop.Services;
using snkrshop.ServicesImplement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace snkrshop.Controllers
{
    public partial class ProductController : ApiController
    {
        ProductService productService = new ProductServiceImpl();
        [Route("product/delete/image")]
        public string DeleteImage(int imageId)
        {
            return productService.DeleteImage(imageId);
        }
    }
}
