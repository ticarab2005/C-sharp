using System.ComponentModel.DataAnnotations;

namespace Artistry.Models
{
    public class LoginUser
    {
        [Required]
        [Display(Name = "login Username")]
        public string logUsername {get;set;}
        [Required]
        [Display(Name = "password")]
        [DataType(DataType.Password)]
        public string logPassword{get;set;}
    }
}