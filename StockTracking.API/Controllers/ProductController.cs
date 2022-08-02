using Microsoft.AspNetCore.Mvc;
using StockTracking.Business.Abstract;
using StockTracking.Model.Dtos.Product;
using StockTracking.Model.Entities;
using StockTracking.Model.Requests.Product;
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
        public IActionResult Get()
        {
            return Ok(_productService.GetAllProducts());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_productService.GetProductById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody]ProductRequest productRequest)
        {
            return Ok(_productService.CreateProduct(productRequest));
        }

        [HttpPut]
        public IActionResult Put([FromBody]ProductRequest productRequest)
        {
            return Ok(_productService.UpdateProduct(productRequest));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);
            return Ok();
        }
    }
}
