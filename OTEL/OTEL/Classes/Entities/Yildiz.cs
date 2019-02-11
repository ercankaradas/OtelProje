using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTEL.Classes.Entities
{
    [Table("Yildizlar")]
    public class Yildiz:DbObject
    {
        public Yildiz(int begenmeSayisi, int begenmemeSayisi)
        {
            BegenmeSayisi = begenmeSayisi;
            BegenmemeSayisi = begenmemeSayisi;
        }
        public Yildiz() { } // Boş Con

        public int BegenmeSayisi { get; set; }
        public int BegenmemeSayisi { get; set; }

        public override string ToString()
        {
            return BegenmemeSayisi.ToString();
        }
    }
}
