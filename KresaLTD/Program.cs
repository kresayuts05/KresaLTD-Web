using CloudinaryDotNet;
using KresaLTD.Infrastructure.Data;
using KresaLTD.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;


public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<KresaLTDDbContext>(options =>
            options.UseSqlServer(connectionString));
        builder.Services.AddDatabaseDeveloperPageExceptionFilter();


        builder.Services.AddControllersWithViews();

        builder.Services.AddDefaultIdentity<User>(options =>
        {
            options.SignIn.RequireConfirmedAccount = false;
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 4;
        })
                   .AddRoles<IdentityRole>()
                   .AddEntityFrameworkStores<KresaLTDDbContext>();

        builder.Services.AddControllersWithViews(options =>
        {
            options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
        });

        //builder.Services.AddAntiforgery(options =>
        //{
        //    options.HeaderName = "X-CSRF-TOKEN";
        //});////

        builder.Services.ConfigureApplicationCookie(options =>
        {
            options.LoginPath = "/User/Login";
            options.LogoutPath = "/User/Logout";
        });

        builder.Services.AddApplicationServices();
        ConfigureCloudaryService(builder.Services, builder.Configuration);

        builder.Services.AddResponseCaching();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseMigrationsEndPoint();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
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

        app.UseResponseCaching();

        app.Run();
    }

    //Cloudinary api
    private static void ConfigureCloudaryService(IServiceCollection services, IConfiguration configuration)
    {
        var cloudName = configuration.GetValue<string>("AccountSettings:CloudName");
        var apiKey = configuration.GetValue<string>("AccountSettings:ApiKey");
        var apiSecret = configuration.GetValue<string>("AccountSettings:ApiSecret");

        if (new[] { cloudName, apiKey, apiSecret }.Any(string.IsNullOrWhiteSpace))
        {
            throw new ArgumentException("Please specify your Cloudinary account Information");
        }

        services.AddSingleton(new Cloudinary(new Account(cloudName, apiKey, apiSecret)));
    }
}