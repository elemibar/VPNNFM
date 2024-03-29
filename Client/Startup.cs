using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Dominio.IRepositorios;
using CasosUso;
using Repositorios;

using Microsoft.AspNetCore.Localization;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace Client
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

            services.AddSession();
            
            services.AddScoped<IRepositorioUsuarios, RepositorioUsuarios>();
            services.AddScoped<IManejadorUsuarios, ManejadorUsuarios>();

            services.AddScoped<IRepositorioVPNs,RepositorioVPNs>();
            services.AddScoped<IManejadorVPNs, ManejadorVPNs>();

            services.AddScoped<IRepositorioActividades,RepositorioActividades>();
            services.AddScoped<IManejadorActividades, ManejadorActividades>();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // CULTURE CORRECTION (Fecha y hora)

            var supportedCultures = new List<CultureInfo>{};
            var es = new CultureInfo("es-ES");
            es.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            es.DateTimeFormat.DateSeparator = "/";
            supportedCultures.Add(es);

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                // Formatting numbers, dates, etc.
                SupportedCultures = supportedCultures,
                // UI strings that we have localized.
                SupportedUICultures = supportedCultures,
            });
            app.Use(async(context, next) =>
            {
                context.Response.Cookies.Append(
                    CookieRequestCultureProvider.DefaultCookieName,
                    CookieRequestCultureProvider.MakeCookieValue(new RequestCulture("es-ES"))
                );
                await next();
            });
            
            ////////////////////////////////////


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

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
