using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using StockTracking.API.Controllers;
using StockTracking.Business.Abstract;
using StockTracking.Model.Dtos.Product;
using System.Collections.Generic;
using Xunit;

namespace StockTracking.Test.ControllerTests
{
    public class ProductControllerTest
    {
        [Fact]
        public void ProductController_Get_shouldReturnOk()
        {
            var productServiceMock = new Mock<IProductService>();

            productServiceMock.Setup(x => x.GetAllProducts())
                              .Returns(new List<GetAllProductsDto>()
                              {
                                  new GetAllProductsDto()
                                  {
                                      Name = "test",
                                      Quantity = 1
                                  }
                              });

            var productController = CreateInstance(productServiceMock);

            var result = productController.Get();

            Assert.IsType<OkObjectResult>(result);
        }

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
