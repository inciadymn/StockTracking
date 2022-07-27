using StockTracking.Model.Entities;
using System.Collections.Generic;

namespace StockTracking.DAL.Abstract
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();

        Category GetCategoryById(int id);

        Category CreateCategory(Category category);

        Category UpdateCategory(Category category);

        void DeleteCategory(int id);
    }
}
