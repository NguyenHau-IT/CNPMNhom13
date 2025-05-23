using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanXe.Models
{
    [Table("CarReview")]
    public class CarReview
    {
        [Key]
        public int ReviewID { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CarID { get; set; }
        public Car Car { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
