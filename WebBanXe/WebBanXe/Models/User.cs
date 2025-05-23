using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanXe.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        [MaxLength(20)]
        public string UserType { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<CarReview> CarReviews { get; set; }
        public ICollection<Favourite> Favourites { get; set; }
        public ICollection<ServiceOrder> ServiceOrders { get; set; }
    }
}
