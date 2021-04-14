using FunWithAspNetCoreMvc.Repository;
using FunWithAspNetCoreMvc.Service;
using FunWithAspNetCoreMvc.Service.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FunWithAspNetCoreMvc
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
            // NOTE: The Visual Studio proposed me to create a MVC project which can also
            // be a RESTful service.

            //// For ASP .NET Core 2.x
            //services.AddMvc();

            services.AddControllersWithViews();

            // The .AddControllersWithViews() call the following methods inside:
            // * .AddMvcCore()
            // * .AddApiExplorer()
            // * .AddAuthorization()
            // * .AddCors()
            // * .AddDataAnnotations()
            // * .AddFormatterMappings()
            // * .AddCacheTagHelper()
            // * .AddViews()
            // * .AddRazorViewEngine()

            //services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<ISettingService, SettingService>();
            services.AddTransient<IGreetingServicecs, GreetingServicecs>();
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
                app.UseExceptionHandler("/Home/Error");
            }

            // It means that we can (HTML, CSS and JavaScript) as a response.
            app.UseStaticFiles();

            //// For ASP .NET Core 2.x
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}