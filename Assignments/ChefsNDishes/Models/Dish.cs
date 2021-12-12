using System;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}
        public string DishName {get;set;}
        public int Tastiness {get;set;}
        public int Calories {get;set;}
        public string Description {get;set;}
        public int NumDish {get;set;}
        public int ChefId {get;set;}
        
        public Chef MyChef {get;set;}
        public DateTime CreatedAt  {get;set;} = DateTime.Now;
        public DateTime UpdatedAt  {get;set;} = DateTime.Now;
    }
}