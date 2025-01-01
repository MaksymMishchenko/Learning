using Microsoft.AspNetCore.Identity;

namespace SportsStoreAPP.Models
{
    public static class IdentitySeedData
    {
        private const string _adminUser = "Admin";
        private const string _adminPassword = "Secret123$";

        public static async Task EnsurePopulated(IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();                

                IdentityUser user = await userManager.FindByIdAsync(_adminUser);

                if (user == null)
                {
                    user = new IdentityUser("Admin");
                    await userManager.CreateAsync(user, _adminPassword);
                }
            }
        }
    }
}
