using StockTracking.DAL.Abstract;
using StockTracking.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.DAL.Concrete.Repository
{
    class ProductRepository : IProductRepository
    {
        private readonly StockTrackingDbContext _context;

        public ProductRepository(StockTrackingDbContext context)
        {
            _context = context; 
        }

        public Product CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void DeleteProduct(int id)
        {
            Product deletedProduct = GetProductById(id);
            _context.Products.Remove(deletedProduct);
            _context.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Where(a => a.Id == id).FirstOrDefault();
        }

        public Product UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return product;
        }
    }
}
