using Application.Services.Models.TypeSafe;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace Application.Services.Infrastructure.Authorization
{
    public class CustomAuthorizeAttribute : Attribute, IAsyncAuthorizationFilter
    {
        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            var controllerName = context.HttpContext.GetRouteData().Values["controller"]?.ToString();
            var actionName = context.HttpContext.GetRouteData().Values["action"]?.ToString();
            var requiredPermission = AuthorizeHelper.GetActionPermission(actionName);

            var claims = context.HttpContext.User.Claims;

            var userPermission = AuthorizeHelper.GetPermissionFromClaim(controllerName, claims);

            if (userPermission is not null &&
                requiredPermission != TS.Permissions.None &&
                userPermission.Contains(requiredPermission))
            {
                return;
            }
            context.Result = new UnauthorizedObjectResult("You don't have access to this function");
        }
    }
}
