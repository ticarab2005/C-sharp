using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId {get;set;}
        
        [Required]
        [Display(Name ="Wedder One")]
        public string WedderOne {get;set;}
        [Display(Name ="Wedder Two")]
        [Required]
        public string WedderTwo {get;set;}
        [DataType(DataType.Date)]
        public DateTime Date {get;set;}
        [Required]
        [Display(Name ="Address")]
        public string Address{get;set;}
        public int UserId {get;set;}
        public User myUser {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<RSVP> RSVPAt {get;set;}
    }
}