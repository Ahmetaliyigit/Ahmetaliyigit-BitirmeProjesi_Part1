using BLL;
using DAL.Context;
using DAL.EfCore;
using Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace E_Ticaret_Prjesi_AHMT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            builder.Services.AddHttpClient();       
            builder.Services.AddDbContext<DataContext>(opts =>
            opts.UseSqlServer(builder.Configuration.GetConnectionString("ProjectConnection"))); // appsetting.json a giderek oradan Proje ba�lant�s�n� al�r ve a�a��da belirtilen S�n�fa yollan�r 

            
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>().
                AddEntityFrameworkStores<DataContext>()
                .AddDefaultTokenProviders();
                

            builder.Services.AddScoped<CategoryDAL>();
            builder.Services.AddScoped<ColorDAL>();
            builder.Services.AddScoped<ProductDAL>();
            builder.Services.AddScoped<GenderDAL>();

            builder.Services.AddScoped<CategoryService>();
            builder.Services.AddScoped<ColorService>();
            builder.Services.AddScoped<GenderService>();
            builder.Services.AddScoped<ProductService>();



            builder.Services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequiredLength = 6;


  

            });

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
