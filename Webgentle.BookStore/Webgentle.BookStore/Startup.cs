using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webgentle.BookStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
            //app.Use(async (context, next)=>
            //{
            //    await context.Response.WriteAsync("This is a frist middlewear restponse");
            //    await next();
            //    await context.Response.WriteAsync("This is a frist middlewear restponse year");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("This is a second middlewear restponse");
            //    await next();
            //    await context.Response.WriteAsync("This is a second middlewear restponse year");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("This is a third middle year");
            //});
            app.UseStaticFiles();

            app.UseRouting();


            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

           
        }
      

    }
}
