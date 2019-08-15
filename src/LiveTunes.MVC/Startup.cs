using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LiveTunes.MVC.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LiveTunes.MVC
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddHttpClient();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ApplicationDbContext a)
        {
            a.MusicCategories.Add(new Models.MusicCategory(3001, "Alternative"));
            a.MusicCategories.Add(new Models.MusicCategory(3002, "Blues & Jazz"));
            a.MusicCategories.Add(new Models.MusicCategory(3003, "Classical"));
            a.MusicCategories.Add(new Models.MusicCategory(3004, "Country"));
            a.MusicCategories.Add(new Models.MusicCategory(3005, "Cultural"));
            a.MusicCategories.Add(new Models.MusicCategory(3006, "EDM / Electronic"));
            a.MusicCategories.Add(new Models.MusicCategory(3007, "Folk"));
            a.MusicCategories.Add(new Models.MusicCategory(3008, "Hip Hop / Rap"));
            a.MusicCategories.Add(new Models.MusicCategory(3009, "Indie"));
            a.MusicCategories.Add(new Models.MusicCategory(3010, "Latin"));
            a.MusicCategories.Add(new Models.MusicCategory(3011, "Metal"));
            a.MusicCategories.Add(new Models.MusicCategory(3012, "Opera"));
            a.MusicCategories.Add(new Models.MusicCategory(3013, "Pop"));
            a.MusicCategories.Add(new Models.MusicCategory(3014, "R&B"));
            a.MusicCategories.Add(new Models.MusicCategory(3015, "Reggae"));
            a.MusicCategories.Add(new Models.MusicCategory(3016, "Religious/Spirtual"));
            a.MusicCategories.Add(new Models.MusicCategory(3017, "Rock"));
            a.MusicCategories.Add(new Models.MusicCategory(3018, "Top 40"));
            a.MusicCategories.Add(new Models.MusicCategory(3019, "Other"));
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
