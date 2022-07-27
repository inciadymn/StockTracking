using Microsoft.Extensions.DependencyInjection;
using StockTracking.DAL.Concrete.Extensions;
using StockTraking.Business.Abstract;
using StockTraking.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTraking.Business.Concrete.Extensions
{
    public static class RegisterService
    {
        public static void AddScopeBusiness(this IServiceCollection services)
        {
            services.AddScopeDAL();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
