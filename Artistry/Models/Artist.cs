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
        public string title {get;set;}
        [Required]
        public string Technique {get;set;}
        [DataType(DataType.Date)]
        public DateTime Date {get;set;}
        [Required]
        public string Description {get;set;}
        public int UserId {get;set;}
        public User myUser {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Skill> difSkill {get;set;}
    }
}