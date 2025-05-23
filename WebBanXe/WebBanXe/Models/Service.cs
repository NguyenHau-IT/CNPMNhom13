using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanXe.Models
{
    [Table("Service")]
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }

        [Required, MaxLength(100)]
        public string ServiceName { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public ICollection<ServiceOrder> ServiceOrders { get; set; }
    }
}
