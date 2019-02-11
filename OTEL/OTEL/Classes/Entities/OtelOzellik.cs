using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTEL.Classes.Entities
{
    [Table("OtelOzellikleri")]
    public class OtelOzellik:DbObject
    {
        public OtelOzellik(Otel otel, Ozellik ozellik)
        {
            Otel = otel;
            Ozellik = ozellik;
        }
        public OtelOzellik() { } // Boş Con

        public Otel Otel { get; set; }
        public Ozellik Ozellik { get; set; }

        public override string ToString()
        {
            return Ozellik.OzellikAdi;
        }
    }
}
