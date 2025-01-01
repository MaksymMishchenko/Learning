using Application.Services.Helper;
using Application.Services.Models.TypeSafe;
using System.Security.Claims;

namespace Application.Services.Infrastructure.Authorization
{
    internal class AuthorizeHelper
    {
        internal static IEnumerable<int> GetPermissionFromClaim(string controllerName, IEnumerable<Claim> claims)
        {
            if (!claims.Any(t => t.Type == controllerName))
            {
                return null;
            }
            // модулі для кожного контроллера. Повертаємо значення Value для модуля. t.Value.To<int>() цей метод реалізовано нижче. Він може бути використаний у всіх проектах в майбутньому
            // він конвертує значення в intі цей мтеод дженерік
            return claims.Where(t => t.Type == controllerName).Select(t => t.Value.To<int>());
        }

        internal static int GetActionPermission(string actionName)
        {
            switch (actionName)
            {
                case "Get":
                    return TS.Permissions.Read;
                case "Add":
                    return TS.Permissions.Write;
                case "Update":
                    return TS.Permissions.Update;
                case "Delete":
                    return TS.Permissions.Delete;
                default:
                    return TS.Permissions.None;
            }
        }
    }
}
