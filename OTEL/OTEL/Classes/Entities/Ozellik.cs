using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTEL.Classes.Entities
{
    [Table("Ozellikler")]
    public class Ozellik : DbObject
    {
        public Ozellik(string ozellikAdi)
        {
            OzellikAdi = ozellikAdi;
        }
        public Ozellik() { } // Boş Con

        [Required]
        [MaxLength(30)]
        public string OzellikAdi { get; set; }

        public override string ToString()
        {
            return OzellikAdi;
        }
    }
}
