using Application.Services.DataContexts;
using Application.Services.Helper;
using Application.Services.Identity;
using Application.Services.Infrastructure.Authorization.Requirements;
using Application.Services.Models;
using Application.Services.Models.TypeSafe;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

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

        public static IServiceCollection AddApplicationJwtAuth(this IServiceCollection services, JwtConfiguration configuration)
        {
            services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateActor = true,
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        RequireExpirationTime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = configuration.Issuer,
                        ValidAudience = configuration.Audience,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.Key))
                    };
                });
            return services;
        }

        public static IServiceCollection AddApplicationAuthorization(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                //Policy - based requirement authorization
                //ModuleController
                options.AddPolicy(TS.Policies.FullControlPolicy, policy =>
                {
                    policy.Requirements.Add(new AdminRequirements());
                });

                options.AddPolicy(TS.Policies.ReadAndWritePolicy, policy =>
                {
                    policy.Requirements.Add(new ContributorRequirements());
                });

                options.AddPolicy(TS.Policies.ReadPolicy, policy =>
                {
                    policy.Requirements.Add(new UserRequirements());
                });


                options.AddPolicy(TS.Policies.GenericPolicy, policy =>
                {
                    policy.Requirements.Add(new ConventionBasedRequirements());
                });

                //options.AddPolicy(TS.Policies.FullControlPolicy, policy =>
                //{
                //    policy.RequireRole(TS.Roles.Admin);
                //});

                //// add policy for contributor and admin role. In this case its OR. 
                //options.AddPolicy(TS.Policies.ReadAndWritePolicy, policy =>
                //{
                //    policy.RequireRole(
                //        TS.Roles.Contributor,
                //        TS.Roles.Admin);
                //});

                ////In this case we use AND

                ////options.AddPolicy(TS.Policies.ReadAndWritePolicy, policy =>
                ////{
                ////    policy.RequireRole(
                ////        TS.Roles.Contributor);
                ////    policy.RequireRole(
                ////        TS.Roles.Admin);
                ////});

                //options.AddPolicy(TS.Policies.ReadPolicy, policy =>
                //{
                //    policy.RequireRole(
                //        TS.Roles.User,
                //        TS.Roles.Contributor,
                //        TS.Roles.Admin);
                //});

                //// claim-based authorization
                //options.AddPolicy("ClaimBasedPolicy", policy =>
                //{
                //    policy.RequireClaim("Student");
                //});

                //options.AddPolicy(TS.Policies.FullControlPolicy, policy =>
                //{
                //    policy.RequireClaim(TS.Contoller.Student,
                //        TS.Permissions.Delete.ToString(),
                //        TS.Permissions.Update.ToString());
                //});

                //options.AddPolicy(TS.Policies.ReadAndWritePolicy, policy =>
                //{
                //    policy.RequireClaim(TS.Contoller.Student,
                //        TS.Permissions.Write.ToString());
                //});

                //options.AddPolicy(TS.Policies.ReadPolicy, policy =>
                //{
                //    policy.RequireClaim(TS.Contoller.Student,
                //        TS.Permissions.Read.ToString());
                //});                
            });

            //services.AddSingleton<IAuthorizationHandler, AdminRequirementHandler>();
            //services.AddSingleton<IAuthorizationHandler, ContributorRequirementHandler>();
            //services.AddSingleton<IAuthorizationHandler, UserRequirementHandler>();

            services.AddSingleton<IAuthorizationHandler, GenericRequirementsHadler>();

            services.AddSingleton<IAuthorizationHandler, ConventionBasedRequirementsHandler>();

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
                    //await userManager.AddClaimAsync(adminUser, new Claim("AdminClaim_User", "value 1"));
                    //await userManager.AddClaimAsync(contributorUser, new Claim("ContributorClaim_User", "value 2"));
                    //await userManager.AddClaimAsync(user, new Claim("UserClaim_User", "value 3"));

                    // Adding Claims to Users
                    await userManager.AddClaimAsync(adminUser, GetAdminClaims(TS.Contoller.Student));
                    await userManager.AddClaimAsync(contributorUser, GetContributorClaims(TS.Contoller.Student));
                    await userManager.AddClaimAsync(user, GetUserClaims(TS.Contoller.Student));

                    // Adding Roles to Users
                    await userManager.AddToRoleAsync(adminUser, TS.Roles.Admin);
                    await userManager.AddToRoleAsync(contributorUser, TS.Roles.Contributor);
                    await userManager.AddToRoleAsync(user, TS.Roles.User);

                    // Adding Claims to Roles
                    //await roleManager.AddClaimAsync(adminRole, new Claim("AdminClaim_Role", "value 1"));
                    //await roleManager.AddClaimAsync(contributorRole, new Claim("ContributorClaim_Role", "value 2"));
                    //await roleManager.AddClaimAsync(userRole, new Claim("UserClaim_Role", "value 3"));

                    //Adding Claims to Roles
                    //await roleManager.AddClaimAsync(adminRole, GetAdminClaims(TS.Contoller.Student));
                    //await roleManager.AddClaimAsync(contributorRole, GetContributorClaims(TS.Contoller.Student));
                    //await roleManager.AddClaimAsync(userRole, GetUserClaims(TS.Contoller.Student));

                    await roleManager.AddClaimAsync(adminRole, GetAdminClaims(TS.Contoller.Module));
                    await roleManager.AddClaimAsync(contributorRole, GetContributorClaims(TS.Contoller.Module));
                    await roleManager.AddClaimAsync(userRole, GetUserClaims(TS.Contoller.Module));

                    await roleManager.AddClaimAsync(adminRole, GetAdminClaims(TS.Contoller.Teacher));
                    await roleManager.AddClaimAsync(contributorRole, GetContributorClaims(TS.Contoller.Teacher));
                    await roleManager.AddClaimAsync(userRole, GetUserClaims(TS.Contoller.Teacher));
                }
            }
            return app;
        }

        private static Claim GetAdminClaims(string controllerName)
        {
            return new Claim(controllerName, ClaimHelper.SerializePermissions(
                TS.Permissions.Read,
                TS.Permissions.Write,
                TS.Permissions.Update,
                TS.Permissions.Delete
                ));
        }

        private static Claim GetContributorClaims(string controllerName)
        {
            return new Claim(controllerName,
                        ClaimHelper.SerializePermissions(
                            TS.Permissions.Read,
                            TS.Permissions.Write
                        ));
        }

        private static Claim GetUserClaims(string controllerName)
        {
            return new Claim(controllerName,
                        ClaimHelper.SerializePermissions(
                            TS.Permissions.Read
                        ));
        }
    }
}
