using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithValidation.Models
{
    public class Dojo
    {
        [Required(ErrorMessage = "Your Name must contain more than 2")]
        [MinLength(2,ErrorMessage ="Name must contain more than 2 characters!")]
        public string personName {get;set;}

        [Required(ErrorMessage ="You must pick a location!")]
        public string dojoLocation {get;set;}
        [Required(ErrorMessage ="Language is required!")]
        // [Display(Language ="Your Name")]
        public string dojoLanguage {get;set;}
        [MinLength(20,ErrorMessage ="Comment isn't required, but if provided, must contain more than 20 characters!")]
        // [Display(Name ="Your Name")]
        public string personComment {get;set;}
    }
}

namespace DojoSurveyWithValidation
{
    public enum dojoLanguage
    {
        None,
        HTML,
        CSS, 
        JavaScript,
        Python,
        CSharp
    }
}