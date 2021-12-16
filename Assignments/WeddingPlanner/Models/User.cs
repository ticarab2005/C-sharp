using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [Display(Name ="First Name")]
        [MinLength(2, ErrorMessage ="First Name must have at least 2 characters!")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name ="Last Name")]
        [MinLength(2, ErrorMessage ="Last Name must have at least 2 characters!")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(8, ErrorMessage ="Password must have a least 8 characters!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Confirm { get; set; }
    }
}