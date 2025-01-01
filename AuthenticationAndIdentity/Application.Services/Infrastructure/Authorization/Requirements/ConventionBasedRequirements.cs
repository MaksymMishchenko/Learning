using Application.Services.Models.TypeSafe;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Application.Services.Infrastructure.Authorization.Requirements
{
    // convention requirement based IAuthorizationRequirement
    public class ConventionBasedRequirements : IAuthorizationRequirement
    {
    }

    public class ConventionBasedRequirementsHandler : AuthorizationHandler<ConventionBasedRequirements>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ConventionBasedRequirementsHandler(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ConventionBasedRequirements requirement)
        {
            var controllerName = _httpContextAccessor.HttpContext.GetRouteData().Values["controller"]?.ToString();
            var actionName = _httpContextAccessor.HttpContext.GetRouteData().Values["action"]?.ToString();
            var requiredPermission = AuthorizeHelper.GetActionPermission(actionName);

            var user = context.User;
            var claims = user.Claims;

            var userPermission = AuthorizeHelper.GetPermissionFromClaim(controllerName, claims);

            if (userPermission is not null &&
                requiredPermission != TS.Permissions.None &&
                userPermission.Contains(requiredPermission))
            {
                context.Succeed(requirement);
            }
            else
            {
                context.Fail();
            }

            return Task.CompletedTask;
        }
    }


}
