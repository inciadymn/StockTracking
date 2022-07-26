using StockTracking.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.DAL.Abstract
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();

        Category GetCategoryById(int id);

        Category CreateCategory(Category product);

        Category UpdateCategory(Category product);

        void DeleteCategory(int id);
    }
}
