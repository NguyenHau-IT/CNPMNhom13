using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebBanXe.Models;

namespace WebBanXe.Models
{
    [Table("Car")]
    public class Car
    {
        [Key]
        public int CarID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [MaxLength(20)]
        public string Status { get; set; }

        public int Year { get; set; }

        [MaxLength(50)]
        public string Color { get; set; }

        // FK
        public int TypeID { get; set; }

        [ForeignKey("TypeID")]
        public virtual CarType CarType { get; set; }

        public int BrandID { get; set; }

        [ForeignKey("BrandID")]
        public virtual CarBrand CarBrand { get; set; }

        public ICollection<CarImage> CarImages { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<CarReview> CarReviews { get; set; }
        public ICollection<Favourite> Favourites { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
