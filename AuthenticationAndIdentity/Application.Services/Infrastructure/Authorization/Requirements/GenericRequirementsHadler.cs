using Application.Services.Models.TypeSafe;
using Microsoft.AspNetCore.Authorization;

namespace Application.Services.Infrastructure.Authorization.Requirements
{
    public class GenericRequirementsHadler : IAuthorizationHandler
    {
        public Task HandleAsync(AuthorizationHandlerContext context)
        {
            var requirements = context.PendingRequirements.ToList();
            var claims = context.User.Claims;

            var userPermission = AuthorizeHelper.GetPermissionFromClaim(TS.Contoller.Module, claims);

            foreach (var requirement in requirements)
            {
                if (requirement is AdminRequirements)
                {
                    if (userPermission is not null &&
                        userPermission.Contains(TS.Permissions.Read) &&
                        userPermission.Contains(TS.Permissions.Write) &&
                        userPermission.Contains(TS.Permissions.Update) &&
                        userPermission.Contains(TS.Permissions.Delete)
                        )
                    {
                        context.Succeed(requirement);
                    }
                    else
                    {
                        context.Fail();
                    }
                }

                else if (requirement is ContributorRequirements)
                {
                    if (userPermission is not null &&
                        userPermission.Contains(TS.Permissions.Read) &&
                        userPermission.Contains(TS.Permissions.Write)
                        )
                    {
                        context.Succeed(requirement);
                    }
                    else
                    {
                        context.Fail();
                    }
                }

                else if (requirement is UserRequirements)
                {
                    if (userPermission is not null &&
                        userPermission.Contains(TS.Permissions.Read)
                        )
                    {
                        context.Succeed(requirement);
                    }
                    else
                    {
                        context.Fail();
                    }
                }
            }
            return Task.CompletedTask;
        }
    }
}
