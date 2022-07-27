using StockTracking.DAL.Abstract;
using StockTracking.Model.Entities;
using StockTraking.Business.Abstract;
using System;
using System.Collections.Generic;

namespace StockTraking.Business.Concrete
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product CreateProduct(Product product)
        {
            if (product != null)
            {
                return _productRepository.CreateProduct(product);
            }
            throw new Exception("null eror");
        }

        public void DeleteProduct(int id)
        {
            if (id > 0)
            {
                _productRepository.DeleteProduct(id);
            }
            throw new Exception("id can not be less than one");
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            if (id > 0)
            {
                return _productRepository.GetProductById(id);
            }
            throw new Exception("id can not be less than one");
        }

        public Product UpdateProduct(Product product)
        {
            return _productRepository.UpdateProduct(product);
        }
    }
}
