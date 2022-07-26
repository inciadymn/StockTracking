using StockTracking.DAL.Abstract;
using StockTracking.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.DAL.Concrete.Repository
{
    class CategoryRepository : ICategoryRepository
    {
        public Category CreateCategory(Category product)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Category UpdateCategory(Category product)
        {
            throw new NotImplementedException();
        }
    }
}
