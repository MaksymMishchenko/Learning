using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Application.Ui.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LoginUser UserCredential { get; set; }

        public LoginModel()
        {

        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (UserCredential.Username == "admin" && UserCredential.Password == "123")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "Ned Stark"),
                    new Claim(ClaimTypes.Role, "Admin"),
                    new Claim("MyClaim 1", "Claim value 1"),
                    new Claim("MyClaim 2", "Claim value 2"),
                };

                ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToPage("/Index");
            }
            return Page();
        }
    }

    public class LoginUser
    {
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
