using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MtoMDemo.Models
{
    public class Actor
    {
        [Key]
        public int ActorId {get;set;}
        [Required]
        public string FirstName {get;set;}
        [Required]
        public string LastName {get;set;}
        public DateTime CreateAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public List<Cast> CastList { get; set; }
    }
}