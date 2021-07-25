using System.Security.Claims;

using static CarRentingSystem.WebConstants;

namespace CarRentingSystem.Infrastructure
{
    public static class ClaimsPrincipalsExtensions
    {
        public static string Id(this ClaimsPrincipal user)
            => user.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        public static bool IsAdmin(this ClaimsPrincipal user)
            => user.IsInRole(AdministratorRoleName);
    }
}
