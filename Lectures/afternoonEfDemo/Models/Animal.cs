using System;
using System.ComponentModel.DataAnnotations;

namespace afternoonEFDemo.Models
{
    public class Animal
    {
        // This is our ID inside of MySQL (ex: 1, 2, 3...)
        [Key]
        public int AnimalID {get;set;}
        public string Species {get;set;}
        public int numLegs {get;set;}
        public bool isMammal {get;set;}
    }
}