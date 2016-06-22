using System.ComponentModel.DataAnnotations;

namespace LunchFinderApi.Models
{
    public class Dish
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int WaitingTime { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ShortDescription { get; set; }
        public bool IsDishOftheDay { get; set; }
        public int DishOfDayNumber { get; set; }
        public string Category { get; set; }

    }
}
