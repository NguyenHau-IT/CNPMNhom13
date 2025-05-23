using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanXe.Models
{
    [Table("CarImage")]
    public class CarImage
    {
        [Key]
        public int ImageId { get; set; }

        [Required]
        public string ImageURL { get; set; }

        public string Description { get; set; }

        public int CarID { get; set; }
        public Car Car { get; set; }
    }
}
