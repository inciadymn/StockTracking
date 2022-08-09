using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using StockTracking.API.Controllers;
using StockTracking.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockTracking.Test.ControllerTests
{
    public class ProductControllerTest
    {
        private ProductController CreateInstance(Mock<IProductService> productServiceMock)
        {
            var productController = new ProductController(productServiceMock.Object)
            {
                ControllerContext = new ControllerContext()
                {
                    HttpContext = new DefaultHttpContext()
                }
            };

            return productController;
        }
    }
}
