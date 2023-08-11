using Esports.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Esports.DataModels;
using Esports.Areas.SignInManager;
using Esports.Services.Contracts;
using Esports.Services;
using Esports.Data.Helpers;
using Esports.Data.Helpers.Contracts;

namespace Esports
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<EsportsDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => 
            {
                options.SignIn.RequireConfirmedEmail = false;
                options.Password.RequiredLength = 8;

            
            })
                .AddSignInManager<MySignInManager>()
                .AddEntityFrameworkStores<EsportsDbContext>();
            builder.Services.AddControllersWithViews(); 

            builder.Services.AddScoped<IPackService, PacksService>();
            builder.Services.AddScoped<ITeamService, TeamService>();
            builder.Services.AddScoped<IImageConverter, ImageConverter>();
            builder.Services.AddScoped<ILeadearboardsService, LeaderboardsService>();
            builder.Services.AddScoped<IUserService, UserService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}