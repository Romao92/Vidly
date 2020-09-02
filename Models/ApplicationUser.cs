using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace Vidly.Models
{
    // Vous pouvez ajouter des données de profil pour l'utilisateur en ajoutant d'autres propriétés à votre classe ApplicationUser. Pour en savoir plus, consultez https://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(255)]
        public string DrivingLicense { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        [StringLength(15)]
        //@"^(?: (?:\+| 00)33|0)     # Dialing code
        //    \s*[1-9]              # First number (from 1 to 9)
        //    (?:[\s.-]*\d{2}){4}   # End of the phone number
        //$"
        [RegularExpression(@"^(?: (?:\+| 00)33|0)\s*[1-9](?:[\s.-]*\d{2}){4}$", ErrorMessage = "Numéro de téléphone sur 15 caractères maximum. Format français : (+33|0)*********")]
        public string Phone { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Notez qu'authenticationType doit correspondre à l'élément défini dans CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Ajouter les revendications personnalisées de l’utilisateur ici
            return userIdentity;
        }
    }
}