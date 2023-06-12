using KresaLTD.Core.Constants;
using System.Security.Claims;

namespace KresaLTD.Extensions
{
    public static class ClaimsPrincipalExtension
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public static bool IsAdministrator(this ClaimsPrincipal user)
        {
            return user.IsInRole(RoleConstants.Administrator);
        }
    }
}
