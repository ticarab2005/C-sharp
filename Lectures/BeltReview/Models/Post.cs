using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BeltReview.Models
{
    public class Post
    {
        [Key]
        public int PostId {get;set;}
        [Required]
        public string URL {get;set;}
        [Required]
        public string Description {get;set;}
        public int UserId {get;set;}
        public User Poster {get;set;}
        public List<Like> LikedBy {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}