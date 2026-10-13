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

            UpdateDateTime();

            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        private void UpdateDateTime()
        {
            lbTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lbWaktu.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
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
            lbDeskripsi.Text = "Scan barcode / ketik kode atau nama + Enter. F3 = Bayar, F4 = Cetak Struk, F5 = Reset";
        }

        private void pnlIsi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKasir_Click(object sender, EventArgs e)
        {
            FormKasir();
            lbJudul.Text = "Kasir (F1)";
            lbDeskripsi.Text = "Scan barcode / ketik kode atau nama + Enter. F3 = Bayar, F4 = Cetak Struk, F5 = Reset";
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fitur Riwayat belum tersedia.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
