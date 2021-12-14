using System;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes1.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}
        [Required(ErrorMessage = "Name of dish is required!")]

        public string DishName {get;set;}
        [Range(1,5, ErrorMessage ="Must be between 1-5")]

        public int Tastiness {get;set;}
        [Required]
        [Range(1,2000, ErrorMessage ="Must be greater than 0")]
        public int Calories {get;set;}
        [Required]
        public string Description {get;set;}
        public int ChefId {get;set;}
        
        public Chef MyChef {get;set;}
        public DateTime CreatedAt  {get;set;} = DateTime.Now;
        public DateTime UpdatedAt  {get;set;} = DateTime.Now;
    }
}