using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTEL
{
    [Table("Musteriler")]
    public class Musteri:DbObject
    {
        public Musteri(string adi, string soyadi, string sifre, string kullaniciAdi, string tel, string email, string tCKN)
        {
            Adi = adi;
            Soyadi = soyadi;
            Sifre = sifre;
            KullaniciAdi = kullaniciAdi;
            Tel = tel;
            Email = email;
            TCKN = tCKN;
        }
        public Musteri() { } // Boş Con

        [Required][MaxLength(20)]
        public string Adi { get; set; }
        [Required][MaxLength(30)]
        public string Soyadi { get; set; }
        [Required][MaxLength(20)]
        public string Sifre { get; set; }
        [Required][MaxLength(30)]
        public string KullaniciAdi { get; set; }
        [MaxLength(11)]
        public string Tel { get; set; }
        [Required] [Index(IsUnique =true)][MaxLength(30)]
        public string Email { get; set; }
        [Required][Index(IsUnique = true)][MaxLength(11)]
        public string TCKN { get; set; }

        public override string ToString()
        {
            return Adi+" "+Soyadi;
        }

    }
}
