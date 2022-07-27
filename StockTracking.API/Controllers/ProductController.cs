using Microsoft.AspNetCore.Mvc;
using StockTracking.Business.Abstract;
using StockTracking.Model.Entities;
using System.Collections.Generic;

namespace StockTracking.API.Controllers
{
    [Route("StockTracking/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
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
        public Product Post([FromBody] Product product)
        {
            return _productService.CreateProduct(product);
        }

        [HttpPut]
        public Product Put([FromBody] Product product)
        {
            return _productService.UpdateProduct(product);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.DeleteProduct(id);
        }
    }
}
