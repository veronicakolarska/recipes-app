using Recipes.Data.Models;
using System.Security.Principal;

namespace Recipes.Desktop.Extensions
{
    public static class IPrincipalExtensions
    {
        public static bool IsAdmin(this IPrincipal principal)
        {
            return principal.IsInRole(Role.Administrator.ToString());
        }

        public static bool IsUser(this IPrincipal principal)
        {
            return principal.IsInRole(Role.User.ToString());
        }
    }
}
