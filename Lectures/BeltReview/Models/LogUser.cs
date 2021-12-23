using System.ComponentModel.DataAnnotations;

namespace BeltReview.Models
{
    public class LogUser
    {
        [Required]
        [EmailAddress]
        public string logEmail {get;set;}

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string logPassword {get;set;}
    }
}