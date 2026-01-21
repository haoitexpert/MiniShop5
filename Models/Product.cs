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
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; } = Category.Food;
        public bool IsActive { get; set; }
        public DateTime AvailableAfter { get; set; } = DateTime.Today;
    }
}
