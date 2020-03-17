using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace ACEmployees.Extensions
{
    /// <summary>
    /// Extensión para el Identity
    /// </summary>
    public static class IdentityExtensions
    {
        /// <summary>
        /// Devuelve el Nombre Completo (campo FullName) del Usuario logeado actualmente (Alfredo Castro)
        /// </summary>
        /// <param name="identity"></param>
        /// <returns></returns>
        public static string GetFullName(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("FullName");
            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}