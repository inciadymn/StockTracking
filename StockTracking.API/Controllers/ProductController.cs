using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockTracking.Model.Entities;
using StockTraking.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTracking.API.Controllers
{
    [Route("StockTracking/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            return _productService.GetAllProducts();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productService.GetProductById(id);
        }

        [HttpPost]
        public Product Post([FromBody]Product product)
        {
            return _productService.CreateProduct(product);
        }

        [HttpPut]
        public Product Put([FromBody]Product product)
        {
            return _productService.UpdateProduct(product);
        }

        [HttpDelete("{id}")]
        public void DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
        }
    }
}
