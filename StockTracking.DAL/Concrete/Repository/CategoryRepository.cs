using Microsoft.EntityFrameworkCore;
using StockTracking.DAL.Abstract;
using StockTracking.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockTracking.DAL.Concrete.Repository
{
    public class CategoryRepository : ICategoryRepository
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

            if (deletedCategory==null)
            {
                throw new ArgumentNullException("category is not exits");
            }
            _context.Categories.Remove(deletedCategory);
            _context.SaveChanges();
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Where(a => a.Id == id).Include(x=>x.Products).FirstOrDefault();
        }

        public Category UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return category;
        }
    }
}
