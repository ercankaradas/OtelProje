using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTEL.Classes.Entities
{
    public class DbObjectSD:DbObject
    {
        public DbObjectSD(bool gecerliMi)
        {
            GecerliMi = true;
        }

        public DbObjectSD()
        {
            GecerliMi = true;
        }

        public bool GecerliMi { get; set; }
    }
}
