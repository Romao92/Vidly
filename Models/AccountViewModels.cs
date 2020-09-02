using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    //public class ExternalLoginConfirmationViewModel
    //{
    //    [Required]
    //    [Display(Name = "Phone number")]
    //    [StringLength(15)]
    //    //@"^(?: (?:\+| 00)33|0)     # Dialing code
    //    //    \s*[1-9]              # First number (from 1 to 9)
    //    //    (?:[\s.-]*\d{2}){4}   # End of the phone number
    //    //$"
    //    [RegularExpression(@"^(?: (?:\+| 00)33|0)\s*[1-9](?:[\s.-]*\d{2}){4}$")]
    //    public string Phone { get; set; }

    //    [Required]
    //    [Display(Name = "Driving License")]
    //    public string DrivingLicense { get; set; }

    //    [Required]
    //    [Display(Name = "Courrier électronique")]
    //    public string Email { get; set; }
    //}

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Mémoriser ce navigateur ?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Courrier électronique")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Courrier électronique")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [Display(Name = "Mémoriser le mot de passe ?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name ="Driving License")]
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

        [Required]
        [EmailAddress]
        [Display(Name = "Courrier électronique")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "La chaîne {0} doit comporter au moins {2} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmer le mot de passe ")]
        [Compare("Password", ErrorMessage = "Le mot de passe et le mot de passe de confirmation ne correspondent pas.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Courrier électronique")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "La chaîne {0} doit comporter au moins {2} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmer le mot de passe")]
        [Compare("Password", ErrorMessage = "Le nouveau mot de passe et le mot de passe de confirmation ne correspondent pas.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}
