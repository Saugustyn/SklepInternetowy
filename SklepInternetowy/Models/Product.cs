using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SklepInternetowy.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
