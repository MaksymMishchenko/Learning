using Application.Services.Models.TypeSafe;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Infrastructure.Authorization.Requirements
{
    public class ContributorRequirements : IAuthorizationRequirement
    {
    }

    public class ContributorRequirementHandler : AuthorizationHandler<ContributorRequirements>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ContributorRequirements requirement)
        {
            var claims = context.User.Claims;

            var userPermissions = AuthorizeHelper.GetPermissionFromClaim(TS.Contoller.Module, claims);

            if (userPermissions is not null &&
               userPermissions.Contains(TS.Permissions.Read) &&
               userPermissions.Contains(TS.Permissions.Write)               
               )
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
