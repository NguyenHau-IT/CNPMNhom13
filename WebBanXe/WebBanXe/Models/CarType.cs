using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanXe.Models
{
    [Table("CarType")]
    public class CarType
    {
        [Key]
        public int TypeID { get; set; }

        [Required, MaxLength(50)]
        public string TypeName { get; set; }

        public string Description { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
