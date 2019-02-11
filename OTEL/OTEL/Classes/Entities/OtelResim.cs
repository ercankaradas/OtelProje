using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTEL.Classes.Entities
{
    [Table("OtelResimleri")]
    public class OtelResim:DbObject
    {
        public OtelResim(Otel otel, byte resim)
        {
            Otel = otel;
            Resim = resim;
        }
        public OtelResim() { } // Boş Con

        public Otel Otel { get; set; }
        public byte Resim { get; set; }

        public override string ToString()
        {
            return Otel.Adi;
        }
    }
}
