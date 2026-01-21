using System.ComponentModel.DataAnnotations;

namespace MiniShop5.Models
{
    public enum Category
    {
        Food,
        Drink,
        Electronics
    }

    public class Product
    {
        [Required, StringLength(50, MinimumLength = 2)]
        public string? Name { get; set; }
        [Range(0.01, 1_000_000)]
        public decimal Price { get; set; }
        public Category Category { get; set; } = Category.Food;
        public bool IsActive { get; set; }
        public DateTime AvailableAfter { get; set; } = DateTime.Today;
    }
}
