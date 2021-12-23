using System;
using System.ComponentModel.DataAnnotations;

namespace Artistry.Models
{
    public class Skill
    {
        [Key]
        public int SkillId {get;set;}
        
        public int UserId {get;set;}
        public int ArtistId {get;set;}
        public User User {get;set;}
        public Artist Artist {get;set;}
    }
}