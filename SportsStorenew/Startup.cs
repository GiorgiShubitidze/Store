using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SportsStorenew.Mail;
using SportsStorenew.Service;
using SportsStoreNew.Areas.Identity.Pages;
using SportsStoreNew.Domain.DB;
using SportsStoreNew.Service;
using SportsStoreNew.Service.Models;

namespace SportsStoreNew
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
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                //options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                //options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
                .AddCookie(options =>
                {
                    options.LoginPath = "/account/google-login";
                })
                 .AddGoogle(options =>
                {
                    options.ClientId = "285283984906-mnue7vn8auq7jat33epco7i48gmvg67i.apps.googleusercontent.com";
                    options.ClientSecret = "N4ZsVHK_rhhj5QyTnLZfJVGp";
                });

            services.AddControllersWithViews();
            services.AddScoped<IBrowsingAppService, BrowsingAppService>();
            services.AddScoped<ICartItems, CartItems>();
            services.AddScoped<ICheckDataService, CheckDataService>();
            services.AddDbContext<SportsStoreDbContext>();
            //services.AddDefaultIdentity<IdentityUser>();
            services.AddTransient<IEmailSender, EmailSender>();
           
            services.AddRazorPages();
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<SportsStoreDbContext>();

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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                       name: "default",
                       pattern: "{categoryName}",
                       defaults: new { controller = "Home", Action = "Index" });
                endpoints.MapControllerRoute(
                                  name: "default",
                                  pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
