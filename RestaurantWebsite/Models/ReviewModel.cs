using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantWebsite.Models
{
    public class ReviewModel
    {
        [Key]
        public int Id { get; set; } //Primary Key

        [Required(ErrorMessage ="Review content is required.")]
        [MaxLength(500, ErrorMessage = "The content cannot exceed 500 characters.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Review rating is required.")]
        [Range(1, 5)]
        public int Rating { get; set; }

        //Foreign Key
        [Required]
        public int ProductId { get; set; }

        [ForeignKey("Id")]
        public ProductModel Product { get; set; }
    }
}
