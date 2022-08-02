using StockTracking.Business.Abstract;
using StockTracking.DAL.Abstract;
using StockTracking.Model.Dtos.Product;
using StockTracking.Model.Entities;
using StockTracking.Model.Requests.Product;
using System;
using System.Collections.Generic;

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

        public List<GetAllProductsDto> GetAllProducts()
        {
            List<Product> products = _productRepository.GetAllProducts();

            List<GetAllProductsDto> allProductsDto = new List<GetAllProductsDto>();

            foreach (var item in products)
            {
                foreach (var itemDto in allProductsDto)
                {
                    itemDto.Name = item.Name;
                    itemDto.Quantity = item.Quantity;
                }
            }

            return allProductsDto;
        }

        public GetProductByIdDto GetProductById(int id)
        {
            if (id > 0)
            {
                Product product= _productRepository.GetProductById(id);

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
                CategoryId=productRequest.CategoryId,
            };

            product= _productRepository.UpdateProduct(product);

            return new CreateOrUpdateProductDto
            {
                Name = product.Name,
                Quantity = product.Quantity,
                CategoryId = product.CategoryId,
            };
        }
    }
}
