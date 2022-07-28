using StockTracking.DAL.Abstract;
using StockTracking.Model.Entities;
using StockTracking.Business.Abstract;
using System;
using System.Collections.Generic;
using StockTracking.Model.Requests.Product;
using StockTracking.Model.Dtos.Product;

namespace StockTracking.Business.Concrete
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public CreateOrUpdateProductDto CreateProduct(ProductRequest productRequest)
        {
            if (productRequest != null)
            {
                Product product = new Product()
                {
                    Name = productRequest.Name,
                    Quantity = productRequest.Quantity,
                    CategoryId = productRequest.CategoryId
                };

                product = _productRepository.CreateProduct(product);
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
