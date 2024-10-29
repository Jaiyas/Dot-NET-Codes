using CodeFirstApproachWith2Tables.Models;
using CodeFirstApproachWith2Tables.Controllers;
using CodeFirstApproachWith2Tables.Repository;
using Microsoft.EntityFrameworkCore;
namespace CodeFirstApproachWith2Tables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<OurHeroDbContext>(db => db.UseSqlServer(builder.Configuration.GetConnectionString("OurHeroConnectionString")), ServiceLifetime.Singleton);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IArticleRepository, ArticleRepository>();
            builder.Services.AddDbContext<TutorialDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString(name: "ConStr")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
