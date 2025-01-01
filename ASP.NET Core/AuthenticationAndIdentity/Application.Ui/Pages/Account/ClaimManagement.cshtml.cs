using Application.Services.Identity;
using Application.Services.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Application.Ui.Pages.Account
{
    public class ClaimManagementModel : PageModel
    {
        private readonly IAuthService _authService;

        public List<Claim> Claims { get; set; }

        [BindProperty]
        public UserClaim Claim { get; set; }

        public ClaimManagementModel(IAuthService authService)
        {
            _authService = authService;
        }
        public void OnGet()
        {
            LoadModel();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var result = await _authService.AddUserClaims(User.Identity.Name, new Claim(Claim.Type, Claim.Value));
            LoadModel();
            return Page();
        }

        private void LoadModel()
        {
            Claims = User.Claims.ToList();
        }
    }
}
