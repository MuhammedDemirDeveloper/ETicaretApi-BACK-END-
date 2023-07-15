using ETicaretApi.Application.Repostories.ProductRepostory;
using ETicaretApi.Persistence.Concretes;
using ETicaretApi.Persistence.RepostoryConcretes.ProductConcretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretDbContext>(options => options.UseSqlServer
            (Configuration.ConnectionString));
            services.AddScoped<IProductReadRepostory, ProductReadRepostory>();
            services.AddScoped<IProductWriteRepostory, ProductWriteRepostory>(); 
            
      
        }
    }
}
