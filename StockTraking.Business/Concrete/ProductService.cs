using StockTracking.Business.Abstract;
using StockTracking.DAL.Abstract;
using StockTracking.Model.Dtos.Product;
using StockTracking.Model.Entities;
using StockTracking.Model.Requests.Product;
using System;
using System.Collections.Generic;
using System.Linq;

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
            if (id < 0)
            {
                throw new Exception("id can not be less than one");
            }
            _productRepository.DeleteProduct(id);
        }

        public List<GetAllProductsDto> GetAllProducts()
        {
            List<GetAllProductsDto> allProductsDto = _productRepository.GetAllProducts()
                                                                       .Select(x => new GetAllProductsDto()
                                                                       {
                                                                           Name = x.Name,
                                                                           Quantity = x.Quantity
                                                                       }).ToList();

            return allProductsDto;
        }

        public GetProductByIdDto GetProductById(int id)
        {
            if (id > 0)
            {
                Product product = _productRepository.GetProductById(id);

                GetProductByIdDto productDto = new GetProductByIdDto
                {
                    Name = product.Name,
                    Quantity = product.Quantity
                };

                return productDto;
            }
            throw new Exception("id can not be less than one");
        }

        public CreateOrUpdateProductDto UpdateProduct(ProductRequest productRequest)
        {
            Product product = new Product
            {
                Name = productRequest.Name,
                Quantity = productRequest.Quantity,
                CategoryId = productRequest.CategoryId,
            };

            product = _productRepository.UpdateProduct(product);

            return new CreateOrUpdateProductDto
            {
                Name = product.Name,
                Quantity = product.Quantity,
                CategoryId = product.CategoryId,
            };
        }
    }
}
