using StockTracking.Model.Dtos.Product;
using StockTracking.Model.Entities;
using StockTracking.Model.Requests.Product;
using System.Collections.Generic;

namespace StockTracking.Business.Abstract
{
    public interface IProductService
    {
        List<GetAllProductsDto> GetAllProducts();

        GetProductByIdDto GetProductById(int id);

        CreateOrUpdateProductDto CreateProduct(ProductRequest productRequest);

        CreateOrUpdateProductDto UpdateProduct(ProductRequest productRequest);

        void DeleteProduct(int id);
    }
}
