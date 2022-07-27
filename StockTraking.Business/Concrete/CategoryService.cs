using StockTracking.Business.Abstract;
using StockTracking.DAL.Abstract;
using StockTracking.Model.Dtos.Category;
using StockTracking.Model.Entities;
using StockTracking.Model.Requests.Category;
using System;
using System.Collections.Generic;

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
            if (id > 0)
            {
                _categoryRepository.DeleteCategory(id);
            }
            throw new Exception("id can not be less than one");
        }

        public List<GetAllCategoryDto> GetAllCategories()
        {
            List<Category> categories = _categoryRepository.GetAllCategories();

            List<GetAllCategoryDto> allCategoryDto = new List<GetAllCategoryDto>();

            foreach (var item in categories)
            {
                foreach (var itemDto in allCategoryDto)
                {
                    itemDto.Name = item.Name;
                }
            }

            return allCategoryDto;
        }

        public GetCategoryByIdDto GetCategoryById(int id)
        {
            if (id > 1)
            {
                Category category = _categoryRepository.GetCategoryById(id);

                GetCategoryByIdDto categoryDto = new GetCategoryByIdDto()
                {
                    Name = category.Name,
                };

                foreach (var item in category.Products)
                {
                    foreach (var itemDto in categoryDto.Products)
                    {
                        itemDto.Name = item.Name;

                    }
                };

                return categoryDto;
            }
            throw new Exception("id can not be less than one");
        }

        public CreateOrUpdateCategoryDto UpdateCategory(CategoryRequest categoryRequest)
        {
            Category category = new Category()
            {
                Name = categoryRequest.Name
            };

            category =_categoryRepository.UpdateCategory(category);

            return new CreateOrUpdateCategoryDto()
            {
                Id=category.Id,
                Name = category.Name
            };
        }
    }
}
