namespace RestaurantWebsite.Models
{
    public class ProductModel
    {
        //A class that will store all the information about our products.
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Alergies { get; set; }
        public double Price { get; set; }
        public int Calories { get; set; }
        
    }
}
