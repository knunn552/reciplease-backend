namespace reciplease_backend.Data.Models
{
    public class Recipe
    {
        public string Name { get; set; } = "";
        public int Servings { get; set; } = 1;
        public string? Notes { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<Cookware>? Cookwares { get; set; }
        public ICollection<Utensil>? Utensils { get; set; }
        public ICollection<Appliance>? Appliances {  get; set; } 
        
    }
}
