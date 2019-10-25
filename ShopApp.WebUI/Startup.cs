using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
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
            services.AddScoped<ICategoryDal, EFCoreCategoryDal>();
            services.AddScoped<ICategoryService, CategoryManager>();

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
            
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
            Path.Combine(Directory.GetCurrentDirectory(), "wwwdata")),
                RequestPath = "/lib"
            });


            app.UseMvc(routes =>
            {

                routes.MapRoute(
                   name: "adminProducts",
                   template: "admin/products",
                   defaults: new {controller = "Admin", action = "Index"}
                   );
                routes.MapRoute(
                   name: "products",
                   template: "products/{controller}/{action}/{category?}"
                   );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        
    }
    }
}
