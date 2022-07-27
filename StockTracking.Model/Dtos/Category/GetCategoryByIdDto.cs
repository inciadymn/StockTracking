using StockTracking.Model.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.Model.Dtos.Category
{
    public class GetCategoryByIdDto
    {
        public string Name { get; set; }
        public List<CategoryProductsDto> Products { get; set; }
    }
}
