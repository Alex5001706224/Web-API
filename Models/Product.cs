using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Assignment_13._2.Models
{
    public enum Make
    {
        Benz = 1,
        Bugatti,
        Lamborghini,
        McLaren
    }
    public class Product
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Please fill in name")]
        [MaxLength(100)]
        public string? PName { get; set; }
        [Display(Name = "Product Description")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Cannot leave with blank")]
        [MaxLength(500, ErrorMessage = "Please limit with 500 character")]
        public string? PDescription { get; set; }
        public double Price { get; set; }
        public string? ImageName { get; set; }
        public Make Manufacture { get; set; }
    }
}
