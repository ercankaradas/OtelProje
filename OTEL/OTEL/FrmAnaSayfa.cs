using OTEL.Classes.Eventler;
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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }      

        private void BtnAra_Click(object sender, EventArgs e)
        {
            FrmOdalar frm = new FrmOdalar();
            frm.Show();
            this.Hide();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            Search search = new Search();
            search.TbSearch(TbAra, "Örn: İstanbul, Hilton");
        }
    }
}
