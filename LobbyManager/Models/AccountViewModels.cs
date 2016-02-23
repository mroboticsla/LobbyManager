using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LobbyManager.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "General_Email", ResourceType = typeof(Resources.Resources))]
        public string Email { get; set; }

        [Required]
        [Display(Name = "General_Name", ResourceType = typeof(Resources.Resources))]
        public string Name { get; set; }

        [Required]
        [Display(Name = "General_Lastname", ResourceType = typeof(Resources.Resources))]
        public string Lastname { get; set; }

        [Display(Name = "General_ProfileImage", ResourceType = typeof(Resources.Resources))]
        public string ProfileImage { get; set; }
    }

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
        [Display(Name = "General_Code", ResourceType = typeof(Resources.Resources))]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Login_RememberBrowser", ResourceType = typeof(Resources.Resources))]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "General_Email", ResourceType = typeof(Resources.Resources))]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "General_Email", ResourceType = typeof(Resources.Resources))]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "General_Password", ResourceType = typeof(Resources.Resources))]
        public string Password { get; set; }

        [Display(Name = "Login_RememberMe", ResourceType = typeof(Resources.Resources))]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "General_Email", ResourceType = typeof(Resources.Resources))]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessageResourceName = "Error_Length", ErrorMessageResourceType = typeof(Resources.Resources), MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "General_Password", ResourceType = typeof(Resources.Resources))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "General_ConfirmPassword", ResourceType = typeof(Resources.Resources))]
        [Compare("Password", ErrorMessageResourceName = "Error_PasswordMatch", ErrorMessageResourceType = typeof(Resources.Resources))]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "General_Email", ResourceType = typeof(Resources.Resources))]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessageResourceName = "Error_Length", ErrorMessageResourceType = typeof(Resources.Resources), MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "General_Password", ResourceType = typeof(Resources.Resources))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "General_ConfirmPassword", ResourceType = typeof(Resources.Resources))]
        [Compare("Password", ErrorMessageResourceName = "Error_PasswordMatch", ErrorMessageResourceType = typeof(Resources.Resources))]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "General_Email", ResourceType = typeof(Resources.Resources))]
        public string Email { get; set; }
    }
}
