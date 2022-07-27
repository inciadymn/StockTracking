using Microsoft.Extensions.DependencyInjection;
using StockTracking.DAL.Concrete.Extensions;
using StockTracking.Business.Abstract;
using StockTracking.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.Business.Concrete.Extensions
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
