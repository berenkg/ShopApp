using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ShopApp.Business.Abstract;
using ShopApp.Business.Concrete;
using ShoppApp.DataAccess.Abstract;
using ShoppApp.DataAccess.Concrete.EFCore;

namespace ShopApp.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Deneme amaçlı eklenmiş bir satırdır. Dependency Injection teknolojisini anlamak için eklenmiştir.
            services.AddScoped<IProductDal, EFCoreProductDal>();

            services.AddScoped<IProductService, ProductManager>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                //dotnet ef database drop
                //dotnet ef migrations add CreateDatabase
                //dotnet ef database update
                SeedDatabase.Seed();
            }
            app.UseMvcWithDefaultRoute();
        }
    }
}
