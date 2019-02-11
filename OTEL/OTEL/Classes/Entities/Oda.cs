using OTEL.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTEL.Classes.Entities
{
    [Table("Odalar")]
    public class Oda:DbObject
    {
        public Oda(Otel oteller, OdaTipi odaTipi, double ucret,string odaNo)
        {
            Oteller = oteller;
            OdaNo = odaNo;
            OdaTipi = odaTipi;
            BosMu = true;
            Ucret = ucret;
        }
        public Oda()
        {
            BosMu = true;
        } // Boş Con

        [Required]
        public Otel Oteller { get; set; }
        [Required]
        [MaxLength(10)]
        public string OdaNo { get; set; }
        [Required]
        public OdaTipi OdaTipi { get; set; }
        [Required]
        public bool BosMu { get; set; }
        [Required]
        public double Ucret { get; set; }

        public override string ToString()
        {
            return OdaNo;
        }

    }
}
