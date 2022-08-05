using StockTracking.Business.Abstract;
using StockTracking.DAL.Abstract;
using StockTracking.Model.Dtos.Category;
using StockTracking.Model.Dtos.Product;
using StockTracking.Model.Entities;
using StockTracking.Model.Requests.Category;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockTracking.Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public CreateOrUpdateCategoryDto CreateCategory(CategoryRequest categoryRequest)
        {
            var category = new Category()
            {
                Name = categoryRequest.Name
            };

            category = _categoryRepository.CreateCategory(category);

            return new CreateOrUpdateCategoryDto()
            {
                Name = category.Name,
                Id = category.Id,
            };
        }

        public void DeleteCategory(int id)
        {
            if (id < 0)
            {
                throw new Exception("id can not be less than one");
            }

            _categoryRepository.DeleteCategory(id); 
        }

        public List<GetAllCategoryDto> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories()
                                      .Select(x => new GetAllCategoryDto()
                                      {
                                          Name = x.Name
                                      }).ToList();
        }

        public GetCategoryByIdDto GetCategoryById(int id)
        {
            Category category = _categoryRepository.GetCategoryById(id);

            if (category == null)
            {
                throw new Exception("category id is not exist");
            }

            GetCategoryByIdDto categoryDto = new GetCategoryByIdDto()
            {
                Name = category.Name,
            };

            categoryDto.Products = new List<CategoryProductsDto>();

            categoryDto.Products = category.Products.Select(x => new CategoryProductsDto()
                                                    {
                                                        Name = x.Name
                                                    }).ToList();

            return categoryDto;
        }

        public CreateOrUpdateCategoryDto UpdateCategory(CategoryRequest categoryRequest, int id)
        {
            Category category = new Category()
            {
                Name = categoryRequest.Name,
                Id=id
            };

            category = _categoryRepository.UpdateCategory(category);

            return new CreateOrUpdateCategoryDto()
            {
                Id = category.Id,
                Name = category.Name
            };
        }
    }
}
