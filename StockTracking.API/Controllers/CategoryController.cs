using Microsoft.AspNetCore.Mvc;
using StockTracking.Business.Abstract;
using StockTracking.Model.Dtos.Category;
using StockTracking.Model.Entities;
using StockTracking.Model.Requests.Category;
using System.Collections.Generic;
using System.Net;

namespace StockTracking.API.Controllers
{
    [Route("StockTracking/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<GetAllCategoryDto>), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            return Ok(_categoryService.GetAllCategories());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_categoryService.GetCategoryById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody]CategoryRequest categoryRequest)
        {
            return Ok(_categoryService.CreateCategory(categoryRequest));
        }

        [HttpPut]
        public IActionResult Put([FromBody]CategoryRequest categoryRequest, int id)
        {
            return Ok( _categoryService.UpdateCategory(categoryRequest, id));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _categoryService.DeleteCategory(id);

            return Ok();
        }
    }
}
