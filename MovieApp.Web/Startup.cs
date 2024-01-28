using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); // MVC
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "home",
                   pattern: "",
                   defaults: new { controller = "Home", action = "Index" }
               );

                endpoints.MapControllerRoute(
                   name: "about",
                   pattern: "about",
                   defaults: new { controller = "Home", action = "About" }
               );

                endpoints.MapControllerRoute(
                   name: "movieList",
                   pattern: "movies/list",
                   defaults: new { controller = "Movies", action = "List" }
               );
                endpoints.MapControllerRoute(
                    name: "movieList",
                    pattern: "movies/list",
                    defaults: new { controller = "Movies", action = "List" }
                );

                endpoints.MapControllerRoute(
                   name: "movieDetails",
                   pattern: "movies/details",
                   defaults: new { controller = "Movies", action = "Details" }
               );
            });
        }
    }
}
