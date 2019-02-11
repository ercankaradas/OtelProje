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
    [Table("Oteller")]
    public class Otel:DbObject
    {
        public Otel(string adi, Il adres, string vergiNo, string resmiAdi, string aciklama)
        {
            Adi = adi;
            Adres = adres;
            VergiNo = vergiNo;
            ResmiAdi = resmiAdi;
            Aciklama = aciklama;
            Yorumlar = new List<Yorum>();
            Yildizlar = new List<Yildiz>(); ;
        }
        public Otel() { } // Boş Con

        [Required][MaxLength(30)]
        public string Adi { get; set; }
        public Il  Adres{ get; set; }
        [Required][Index(IsUnique = true)][MaxLength(15)]
        public string VergiNo { get; set; }
        [Required][MaxLength(50)]
        public string ResmiAdi { get; set; }
        [MaxLength(250)]
        public string Aciklama { get; set; }
        public List<Yorum> Yorumlar { get; set; }
        public List<Yildiz> Yildizlar { get; set; }

        public override string ToString()
        {
            return Adi;
        }
    }
}
