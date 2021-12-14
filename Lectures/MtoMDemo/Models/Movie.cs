using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MtoMDemo.Models
{
    public class Movie
    {
        [Key]
        public int MovieId {get;set;}
        [Required]
        public string Title {get;set;}
        [Required]
        public string Genre {get;set;}
        [Required]
        public int ReleaseYear {get;set;}
        public DateTime CreateAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public List<Cast> CastList { get; set; }
    }
}