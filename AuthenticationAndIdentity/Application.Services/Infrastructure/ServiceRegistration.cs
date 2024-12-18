using Application.Services.DataContexts;
using Application.Services.Identity;
using Application.Services.Models.TypeSafe;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Claims;

namespace Application.Services.Infrastructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<UserIdentityContext>(options =>
                {
                    options.UseSqlServer(connectionString);
                });

            services.AddScoped<IAuthService, AuthService>();

            return services;
        }

        public static IdentityBuilder AddApplicationIdentity(this IServiceCollection services)
        {
            return services.AddDefaultIdentity<IdentityUser>(options =>
            {
                // configuration can be written here:
                // builder.Services.Configure<IdentityOptions>
                options.SignIn.RequireConfirmedAccount = true;

                // Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 3;
                options.Password.RequiredUniqueChars = 0;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;

            })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<UserIdentityContext>();
        }

        public static IServiceCollection AddApplicationCookieAuth(this IServiceCollection services)
        {
            services
                .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
            {
                options.Cookie.Name = "My_Cookie_Name_In_Browser";
                // Cookie settings
                // configuration can be written here:
                // builder.Services.ConfigureApplicationCookie

                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                options.LoginPath = "/Account/Login";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
            });
            return services;
        }

        public static async Task<IApplicationBuilder> SeedDataAsync(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var cntx = scope.ServiceProvider.GetRequiredService<UserIdentityContext>();
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                await cntx.Database.EnsureDeletedAsync();

                if (await cntx.Database.EnsureCreatedAsync())
                {
                    // Creating Role Entities
                    var adminRole = new IdentityRole(TS.Roles.Admin);
                    var contributorRole = new IdentityRole(TS.Roles.Contributor);
                    var userRole = new IdentityRole(TS.Roles.User);

                    // Adding Roles
                    await roleManager.CreateAsync(adminRole);
                    await roleManager.CreateAsync(contributorRole);
                    await roleManager.CreateAsync(userRole);

                    // Creating User Entities
                    var adminUser = new IdentityUser() { UserName = "admin", Email = "admin@test.com" };
                    var contributorUser = new IdentityUser() { UserName = "cont", Email = "c@test.com" };
                    var user = new IdentityUser() { UserName = "user", Email = "user@test.com" };

                    // Adding Users with Password
                    await userManager.CreateAsync(adminUser, "123");
                    await userManager.CreateAsync(contributorUser, "123");
                    await userManager.CreateAsync(user, "123");

                    // Adding Claims to Users
                    await userManager.AddClaimAsync(adminUser, new Claim("AdminClaim_User", "value 1"));
                    await userManager.AddClaimAsync(contributorUser, new Claim("ContributorClaim_User", "value 2"));
                    await userManager.AddClaimAsync(user, new Claim("UserClaim_User", "value 3"));

                    // Adding Roles to Users
                    await userManager.AddToRoleAsync(adminUser, TS.Roles.Admin);
                    await userManager.AddToRoleAsync(contributorUser, TS.Roles.Contributor);
                    await userManager.AddToRoleAsync(user, TS.Roles.User);

                    // Adding Claims to Roles
                    await roleManager.AddClaimAsync(adminRole, new Claim("AdminClaim_Role", "value 1"));
                    await roleManager.AddClaimAsync(contributorRole, new Claim("ContributorClaim_Role", "value 2"));
                    await roleManager.AddClaimAsync(userRole, new Claim("UserClaim_Role", "value 3"));
                }
            }
            return app;
        }
    }
}
