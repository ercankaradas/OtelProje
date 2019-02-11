using OTEL.Classes.Eventler;
using OTEL.Classes.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTEL
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            LabelStyle labelStyle = new LabelStyle();
            labelStyle.Style(LblGiris, "#cfcfc0", "#fff404");
            labelStyle.Style(LblKaydol, "#cfcfc0", "#fff404");
            labelStyle.Style(label7, "#000000", "#000000", "#FFF404", "#F3BA00");
            ButtonStyle buttonStyle = new ButtonStyle();
            buttonStyle.Style(BtnAra, "#000000", "#000000", "#FFF404", "#F3BA00");
            Search search = new Search();
            search.TbSearch(TbAra, "Örn: İstanbul, Hilton");
        }
    }
}
