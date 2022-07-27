using StockTracking.DAL.Abstract;
using StockTracking.Model.Entities;
using StockTraking.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTraking.Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category CreateCategory(Category category)
        {
            return _categoryRepository.CreateCategory(category);
        }

        public void DeleteCategory(int id)
        {
            if (id>0)
            {
                _categoryRepository.DeleteCategory(id);
            }
            throw new Exception("id can not be less than one");
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories();
        }

        public Category GetCategoryById(int id)
        {
            if (id>1)
            {
                return _categoryRepository.GetCategoryById(id);
            }
            throw new Exception("id can not be less than one");
        }

        public Category UpdateCategory(Category category)
        {
            return _categoryRepository.UpdateCategory(category);
        }
    }
}
