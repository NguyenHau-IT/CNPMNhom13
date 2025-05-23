using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebBanXe.Models;

namespace WebBanXe.Models
{
    [Table("CarBrand")]
    public class CarBrand
    {
        [Key]
        public int BrandID { get; set; }

        [Required, MaxLength(50)]
        public string BrandName { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
