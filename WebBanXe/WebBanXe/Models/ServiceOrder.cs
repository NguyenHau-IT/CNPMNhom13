using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanXe.Models
{
    [Table("ServiceOrder")]
    public class ServiceOrder
    {
        [Key, Column(Order = 0)]
        public int ServiceID { get; set; }
        public Service Service { get; set; }

        [Key, Column(Order = 1)]
        public DateTime ServiceDate { get; set; }

        public string ServiceStatus { get; set; }

        public string Notes { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
