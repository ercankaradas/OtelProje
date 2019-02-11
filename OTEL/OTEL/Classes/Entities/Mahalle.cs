using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTEL.Classes.Entities
{
    [Table("Mahalleler")]
    public class Mahalle:DbObject
    {
        public Mahalle(string mahalleAdi)
        {
            MahalleAdi = mahalleAdi;
        }
        public Mahalle() { } // Boş Con

        [Required]
        [MaxLength(40)]
        public string MahalleAdi { get; set; }

        public override string ToString()
        {
            return MahalleAdi;
        }
    }
}
