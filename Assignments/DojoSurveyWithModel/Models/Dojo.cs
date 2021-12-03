using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithModel.Models
{
    public class Dojo
    {
        public string personName {get;set;}
        public string dojoLocation {get;set;}
        public string dojoLanguage {get;set;}
        public string personComment {get;set;}
    }
}
