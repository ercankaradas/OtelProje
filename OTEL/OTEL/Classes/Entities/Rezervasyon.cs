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
    [Table("Rezervasyonlar")]
    public class Rezervasyon:DbObject
    {
        public Rezervasyon(Musteri musteri, Oda oda, short kisiSayi, DateTime chenkIn, DateTime chenkOut, OdemeZamani odemeZamani)
        {
            this.musteri = musteri;
            this.oda = oda;
            OnaylandıMı = false;
            KisiSayisi = kisiSayi;
            CheckIn = chenkIn;
            CheckOut = chenkOut;
            this.odemeZamani = odemeZamani;
        }
        public Rezervasyon() { OnaylandıMı = false; } // Boş Con

        [Required]
        public Musteri musteri { get; set; }
        [Required]
        public Oda oda { get; set; }
        [Required]
        public bool OnaylandıMı { get; set; }
        [Required]
        public Int16 KisiSayisi { get; set; }
        [Required]
        public DateTime CheckIn { get; set; }
        [Required]
        public DateTime CheckOut { get; set; }
        [Required]
        public OdemeZamani odemeZamani { get; set; }

        public override string ToString()
        {
            return musteri.Adi;
        }
    }
}
