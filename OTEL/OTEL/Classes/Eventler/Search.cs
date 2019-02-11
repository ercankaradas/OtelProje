using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTEL.Classes.Eventler
{
    public class Search
    {
        public void TbSearch(TextBox Tb, string Text)
        {
            Tb.Text = Text;
            // Olaylar
            Tb.Enter += (sender, args) =>
            {
                if (Tb.Text == Text)
                {
                    Tb.Text = "";
                    Tb.ForeColor = ColorTranslator.FromHtml("#000000");
                }
            };
            
            Tb.Leave += (sender, args) =>
            {
                if (Tb.Text == "")
                {
                    Tb.Text = Text;
                    Tb.ForeColor = Color.LightGray;
                }
            };
        }
    }
}
