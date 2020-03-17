using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ACEmployees.Consts;

namespace ACEmployees.Models
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            userIdentity.AddClaim(new Claim("FullName", this.FullName));
            return userIdentity;
        }

        /// <summary>
        /// Se agrega el campo adicional Nombre Completo (FullName) al ApplicationUser (Alfredo Castro)
        /// </summary>
        [Display( Name = "Nombre Completo")]
        [Required(ErrorMessage = "Por favor introduzca el {0}")]
        [StringLength(256, ErrorMessage = "El {0} debe tener al menos {2} y un máximo de {1} caracteres.", MinimumLength = 2)]
        [RegularExpression(RegExConsts.NameRegEx, ErrorMessage = "Introduzca un Nombre Válido")]
        public string FullName { get; set; }
    }
}