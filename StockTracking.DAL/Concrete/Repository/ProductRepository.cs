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
        private readonly StockTrakingDbContext _context;

        public ProductRepository(StockTrakingDbContext context)
        {
            _context = context; 
        }

        public Product CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
