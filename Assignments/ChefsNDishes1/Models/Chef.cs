using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes1.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}
        [Required(ErrorMessage ="First name is required")]
        public string FirstName {get;set;}
        [Required(ErrorMessage ="Last name is required")]

        public string LastName {get;set;}
        [Required]
        public DateTime DoB {get;set;} = DateTime.Now;
        public List<Dish> MyDishes {get;set;}
        public DateTime CreatedAt  {get;set;} = DateTime.Now;
        public DateTime UpdatedAt  {get;set;} = DateTime.Now;
    }
}