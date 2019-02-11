using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTEL.Classes.Entities
{
    [Table("Iller")]
    public class Il:DbObject
    {
        public Il(string ılAdi, List<Ilce> ılceler)
        {
            IlAdi = ılAdi;
            Ilceler = new List<Ilce>();
        }
        public Il(){} // Boş Con

        [Required]
        [MaxLength(20)]
        public string IlAdi { get; set; }
        public List<Ilce> Ilceler { get; set; }

        public override string ToString()
        {
            return IlAdi;
        }
    }
}
