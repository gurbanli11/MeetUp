using Meetup.DAL;
using Meetup.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Meetup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            //builder.Services.AddIdentity<AppUser, IdentityRole>(opt =>
            //{
            //    opt.Password.RequireNonAlphanumeric = false;
            //}).AddEntityFrameworkStores<AppDbContext>();
            builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

            var app = builder.Build();

            //if (!app.Environment.IsDevelopment())
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //}
            //app.UseRouting();
            //app.UseAuthorization();
            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Account}/{action=Register}/{id?}");
            //app.Run();

            app.UseStaticFiles();


            app.MapControllerRoute(
              name: "areas",
              pattern: "{area:exists}/{controller=admin}/{action=Index}/{id?}"
            );


            app.MapControllerRoute(
                  "Default",
                 "{controller=Home}/{action=index}/{id?}"
                );

            app.Run();
        }
    }
}