using Application.Services.Helper;
using Application.Services.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Application.Services.Identity
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHttpContextAccessor _httpContext;

        public AuthService(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IHttpContextAccessor httpContext
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _httpContext = httpContext;
        }

        public async Task GenerateCookieAuthentication(string username)
        {
            var claims = await GetClaims(username);

            ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            ClaimsPrincipal principal = new ClaimsPrincipal(identity);

            await _httpContext.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
        }

        private async Task<List<Claim>> GetClaims(string username)
        {
            var user = await _userManager.FindByNameAsync(username);

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, username),
            };

            var permissionClaims = new List<Claim>();
            permissionClaims.AddRange(GetClaimsSeparated(await _userManager.GetClaimsAsync(user)));

            //claims.AddRange(await _userManager.GetClaimsAsync(user));
            //claims.AddRange(GetClaimsSeparated(await _userManager.GetClaimsAsync(user)));
            var roles = await _userManager.GetRolesAsync(user);

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));

                var identityRole = await _roleManager.FindByNameAsync(role);
                permissionClaims.AddRange(GetClaimsSeparated(await _roleManager.GetClaimsAsync(identityRole)));
                //claims.AddRange(await _roleManager.GetClaimsAsync(identityRole));
                //claims.AddRange(GetClaimsSeparated(await _roleManager.GetClaimsAsync(identityRole)));
            }

            claims.AddRange(permissionClaims.OrderBy(t => t.Type));
            return claims;
        }

        public async Task<bool> Login(LoginUser credentials)
        {
            var identityUser = await _userManager.FindByNameAsync(credentials.UserName);
            if (identityUser != null)
            {
                return await _userManager.CheckPasswordAsync(identityUser, credentials.Password);
            }
            return false;
        }

        public async Task Logout()
        {
            await _httpContext.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }

        public async Task<bool> RegisterUser(LoginUser user)
        {
            var identityUser = new IdentityUser
            {
                UserName = user.UserName,
                Email = user.UserName
            };

            var result = await _userManager.CreateAsync(identityUser, user.Password);
            return result.Succeeded;
        }

        public async Task<string> GenerateTokenString(string user, JwtConfiguration jwtConfig)
        {
            var claims = await GetClaims(user);
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtConfig.Key));

            var signingCred = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var securityToken = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(60),
                issuer: jwtConfig.Issuer,
                audience: jwtConfig.Audience,
                signingCredentials: signingCred);

            string tokenString = new JwtSecurityTokenHandler().WriteToken(securityToken);
            return tokenString;
        }

        public async Task<bool> AddUserClaims(string user, Claim claim)
        {
            var identityUser = await _userManager.FindByNameAsync(user);
            if (identityUser is null)
            {
                return false;
            }

            var result = await _userManager.AddClaimAsync(identityUser, claim);
            return result.Succeeded;
        }

        private List<Claim> GetClaimsSeparated(IList<Claim> claims)
        {
            var result = new List<Claim>();

            foreach (var claim in claims)
            {
                result.AddRange(claim.DeserializePermissions().Select(t => new Claim(claim.Type, t.ToString())));
            }
            return result;

        }
    }
}
