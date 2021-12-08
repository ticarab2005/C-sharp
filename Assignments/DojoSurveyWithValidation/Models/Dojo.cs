using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithValidation.Models
{
    public class Dojo
    {
        [Required(ErrorMessage = "Please enter your name!")]
        [MinLength(2,ErrorMessage ="Name must contain more than 2 characters!")]
        public string personName {get;set;}

        [Required(ErrorMessage ="You must pick a location!")]
        public string dojoLocation {get;set;}
        
        [Required(ErrorMessage ="You must pick a language!")]
        // [Display(Language ="Your Name")]
        public string dojoLanguage {get;set;}
        [MinLength(20,ErrorMessage ="Must contain more than 20 characters!")]
        // [Display(Name ="Your Name")]
        public string personComment {get;set;}
    }
}
