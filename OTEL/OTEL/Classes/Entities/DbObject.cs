using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTEL
{
    public class DbObject
    {
        public DbObject()
        {
            ID = Guid.NewGuid().ToString();
            OlusturulmaTarihi = DateTime.Now;
            OlusturanKisiID = "ercan";
        }

        [Key]
        [Required]
        public string ID { get; set; }
        [Required]
        public DateTime OlusturulmaTarihi { get; set; }
        [Required]
        [MaxLength(128)]
        public string OlusturanKisiID { get; set; }
        public DateTime GuncellenmeTarihi { get; set; }
        [MaxLength(128)]
        public string GuncelleyenKisiID { get; set; }
    }
}
