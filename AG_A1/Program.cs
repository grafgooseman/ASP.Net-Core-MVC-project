using AG_A1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AG_A1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<StudentContext>(options => options.UseSqlServer(
                builder.Configuration.GetConnectionString("DefaultConnection")
            ));

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<StudentContext>();
                context.Database.EnsureCreated();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute("", "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}