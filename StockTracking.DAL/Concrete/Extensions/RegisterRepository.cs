using Microsoft.Extensions.DependencyInjection;
using StockTracking.DAL.Abstract;
using StockTracking.DAL.Concrete.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.DAL.Concrete.Extensions
{
    public static class RegisterRepository
    {
        public static void AddScopeDAL(this IServiceCollection services)
        {
            services.AddDbContext<StockTrackingDbContext>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
        }
    }
}
