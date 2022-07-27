using Microsoft.AspNetCore.Mvc;
using StockTracking.Business.Abstract;
using StockTracking.Model.Entities;
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
        [ProducesResponseType(typeof(List<Category>), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            return Ok(_categoryService.GetAllCategories());
        }

        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _categoryService.GetCategoryById(id);
        }

        [HttpPost]
        public Category Post([FromBody] Category category)
        {
            return _categoryService.CreateCategory(category);
        }

        [HttpPut]
        public Category Put([FromBody] Category category)
        {
            return _categoryService.UpdateCategory(category);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _categoryService.DeleteCategory(id);
        }
    }
}
