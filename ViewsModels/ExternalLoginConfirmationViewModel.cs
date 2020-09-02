using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.ViewsModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Phone number")]
        [StringLength(15)]
        //@"^(?: (?:\+| 00)33|0)     # Dialing code
        //    \s*[1-9]              # First number (from 1 to 9)
        //    (?:[\s.-]*\d{2}){4}   # End of the phone number
        //$"
        [RegularExpression(@"^(?: (?:\+| 00)33|0)\s*[1-9](?:[\s.-]*\d{2}){4}$", ErrorMessage = "Numéro de téléphone sur 15 caractères maximum. Format français : (+33|0)*********")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Driving License")]
        public string DrivingLicense { get; set; }

        [Required]
        [Display(Name = "Courrier électronique")]
        public string Email { get; set; }
    }
}