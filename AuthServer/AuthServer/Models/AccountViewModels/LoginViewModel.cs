using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AuthServer.Models.AccountViewModels
{
    #region "Original code - Commented out"
    public class LoginViewModel
    {
        [Required]
        //[EmailAddress]
        //public string Email { get; set; }
        public string Username { get;  set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
        //public object Username { get; internal set; }
        public object RememberLogin { get; internal set; }
        public string Email { get; internal set; }
    }
    #endregion
    //public class LoginViewModel 
    //{
    //    [Required]
    //    public string Username { get; set; }
    //    [Required]
    //    [DataType(DataType.Password)]
    //    public string Password { get; set; }
    //    public string ReturnUrl { get; set; }
    //    [Display(Name = "Remember me?")]
    //    public bool RememberMe { get; set; }
    //    public object RememberLogin { get; internal set; }
    //    public string Email { get; set; }

    //    public bool AllowRememberLogin { get; set; }
    //    public bool EnableLocalLogin { get; set; }

    //    public IEnumerable<ExternalProvider> ExternalProviders { get; set; }
    //    //public IEnumerable<ExternalProvider> VisibleExternalProviders => ExternalProviders.Where(x => !String.IsNullOrWhiteSpace(x.DisplayName));

    //    public bool IsExternalLoginOnly => EnableLocalLogin == false && ExternalProviders?.Count() == 1;
    //    public string ExternalLoginScheme => IsExternalLoginOnly ? ExternalProviders?.SingleOrDefault()?.AuthenticationScheme : null;
    //}
}
