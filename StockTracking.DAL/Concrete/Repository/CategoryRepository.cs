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
        private readonly StockTrackingDbContext _context;
        public CategoryRepository(StockTrackingDbContext context)
        {
            _context = context;
        }

        public Category CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public void DeleteCategory(int id)
        {
            Category deletedCategory = GetCategoryById(id);
            _context.Categories.Remove(deletedCategory);
            _context.SaveChanges();
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Where(a => a.Id == id).FirstOrDefault();
        }

        public Category UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return category;
        }
    }
}
