using StockTracking.Model.Entities;
using System.Collections.Generic;

namespace StockTracking.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAllProducts();

        Product GetProductById(int id);

        Product CreateProduct(Product product);

        Product UpdateProduct(Product product);

        void DeleteProduct(int id);
    }
}
