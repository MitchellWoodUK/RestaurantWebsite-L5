using System.ComponentModel.DataAnnotations;

namespace RestaurantWebsite.Models
{
    public class ProductModel
    {
        //A class that will store all the information about our products.
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Product name is required, please enter name.")]
        [StringLength(50, ErrorMessage ="Product name cannot exceed 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Product description is required, please enter description.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Product alergies is required, please enter alergies.")]
        public string Alergies { get; set; }

        [Required(ErrorMessage = "Product price is required, please enter price.")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Product calories is required, please enter calories.")]
        public int Calories { get; set; }
        
    }
}
