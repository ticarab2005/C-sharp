using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public int Age {get;set;}
        public int NumDish {get;set;}
        public List<Dish> MyDishes {get;set;}
        public DateTime CreatedAt  {get;set;} = DateTime.Now;
        public DateTime UpdatedAt  {get;set;} = DateTime.Now;
    }
}