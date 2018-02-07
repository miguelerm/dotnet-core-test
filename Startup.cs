using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using mvc_test.Constraints;
using mvc_test.Filters;

namespace mvc_test
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
            services.AddMvc(config => {
                config.Filters.Add(typeof(LogActionFilterAttribute));
                config.Filters.Add(typeof(BadRequestfilterAttribute));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "blog",
                    template: "blog/{year:int}/{month:int}/{day:int}",
                    defaults: new { controller = "Home", action = "Blog" });

                routes.MapRoute(
                    name: "blog3",
                    template: "blog/{make}/{model}/{zipcode}",
                    defaults: new { controller = "Home", action = "BlogMakeModel" },
                    constraints: new { make = new MakeRouteConstraint()  });

                routes.MapRoute(
                    name: "blog2",
                    template: "blog/{category}/{subcategory}/{article}",
                    defaults: new { controller = "Home", action = "BlogArticle" });

            });
        }
    }
}
