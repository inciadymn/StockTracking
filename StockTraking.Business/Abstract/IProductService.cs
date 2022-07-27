using StockTracking.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTraking.Business.Abstract
{
    interface IProductService
    {
        List<Product> GetAllProducts();

        Product GetProductById(int id);

        Product CreateProduct(Product product);

        Product UpdateProduct(Product product);

        void DeleteProduct(int id);
    }
}
