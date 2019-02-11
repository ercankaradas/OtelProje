using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTEL.Classes.Entities
{
    [Table("Yorumlar")]
    public class Yorum:DbObject
    {
        public Yorum(Musteri musteriler, string yorumBasligi, string yorumIcerigi)
        {
            Musteriler = musteriler;
            YorumBasligi = yorumBasligi;
            YorumIcerigi = yorumIcerigi;
            Yıldızlar = new List<Yildiz>();
        }
        public Yorum() { } // Boş Con

        public Musteri Musteriler { get; set; }
        [MaxLength(50)]
        public string YorumBasligi { get; set; }
        [MaxLength(250)]
        public string YorumIcerigi { get; set; }
        public List<Yildiz> Yıldızlar { get; set; }

        public override string ToString()
        {
            return YorumBasligi;
        }
    }
}
