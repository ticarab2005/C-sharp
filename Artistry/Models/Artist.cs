using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Artistry.Models
{
    public class Artist
    {
        [Key]
        public int ArtistId {get;set;}
        
        [Required]
        [Display(Name ="Artist name")]
        public string Name {get;set;}
        [DataType(DataType.Date)]
        public DateTime Date {get;set;}
        [Required]
        [Display(Name ="Address")]
        public string Address{get;set;}
        public int UserId {get;set;}
        public User myUser {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Skill> difSkill {get;set;}
    }
}