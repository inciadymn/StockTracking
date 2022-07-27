using StockTracking.Model.Dtos.Category;
using StockTracking.Model.Entities;
using StockTracking.Model.Requests.Category;
using System.Collections.Generic;

namespace StockTracking.Business.Abstract
{
    public interface ICategoryService
    {
        List<GetAllCategoryDto> GetAllCategories();

        GetCategoryByIdDto GetCategoryById(int id);

        CreateOrUpdateCategoryDto CreateCategory(CategoryRequest categoryRequest);

        CreateOrUpdateCategoryDto UpdateCategory(CategoryRequest categoryRequest);

        void DeleteCategory(int id);
    }
}
