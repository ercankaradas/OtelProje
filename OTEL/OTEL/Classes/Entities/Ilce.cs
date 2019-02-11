using OTEL.Classes.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTEL
{
    [Table("Ilceler")]
    public class Ilce:DbObject
    {
        public Ilce(string ılceAdi)
        {
            IlceAdi = ılceAdi;
            Mahalleler = new List<Mahalle>();
        }
        public Ilce() { } // Boş Con

        [Required]
        [MaxLength(40)]
        public string IlceAdi { get; set; }
        public List<Mahalle> Mahalleler { get; set; }

        public override string ToString()
        {
            return IlceAdi;
        }
    }
}
