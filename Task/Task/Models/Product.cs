using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Is Required")]
        [MinLength(3, ErrorMessage = "Name must be at least 3 char")]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 char")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [MaxLength(250, ErrorMessage = "Description cannot exceed 250 char")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price Is Required")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Rate Is Required")]
        [Range(1, 5, ErrorMessage = "Rate must be between 1 and 5")]
        [Display(Name = "Rating")]
        public int rate { get; set; }
    }
}