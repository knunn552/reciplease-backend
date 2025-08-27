namespace reciplease_backend.Data.Models
{
    public class Ingredient
    {
        public string Name { get; set; } = "";
        public decimal Quantity { get; set; } = 0m;
        public string? Unit { get; set; } // e.g., "g", "cup", "tbsp"
    }
}
