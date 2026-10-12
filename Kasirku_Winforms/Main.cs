using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasirku_Winforms
{
    public partial class Main : Form
    {
        private Kasir KS = null;
        public Main()
        {
            InitializeComponent();
        }

        public void FormKasir()
        {
            if (pnlIsi.Controls.Count > 0) pnlIsi.Controls.Clear();
            KS = new Kasir();
            KS.TopLevel = false;
            KS.WindowState = FormWindowState.Maximized;
            KS.FormBorderStyle = FormBorderStyle.None;
            KS.Dock = DockStyle.Fill;
            pnlIsi.Controls.Add(KS);
            KS.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FormKasir();
            lbJudul.Text = "Kasir (F1)";
            lbDeskripsi.Text = "Scan barcode / ketik kode atau nama + Enter. F5 = Bayar, F6 = Reset, F7 = Cetak Struk PDF";
        }

        private void pnlIsi_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
