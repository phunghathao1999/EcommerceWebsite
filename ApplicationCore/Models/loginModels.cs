using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Models
{
    public class loginModels
    {
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        [Required]
        [DataType(DataType.Password)]
        public string Password {get;set;}
        [Display(Name = "RememberMe")]
        public bool RememberMe {get;set;}
    }
}