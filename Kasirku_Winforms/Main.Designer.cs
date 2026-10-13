namespace Kasirku_Winforms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.el = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tlpDasar = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnlJudul = new System.Windows.Forms.Panel();
            this.tplJudul = new System.Windows.Forms.TableLayoutPanel();
            this.lbJudul = new System.Windows.Forms.Label();
            this.lbDeskripsi = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.pnlIsi = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTanggal = new System.Windows.Forms.Label();
            this.lbWaktu = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnKasir = new Guna.UI2.WinForms.Guna2Button();
            this.btnRiwayat = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.tlpDasar.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.pnlJudul.SuspendLayout();
            this.tplJudul.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.tlpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // el
            // 
            this.el.TargetControl = this;
            // 
            // tlpDasar
            // 
            this.tlpDasar.ColumnCount = 1;
            this.tlpDasar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDasar.Controls.Add(this.tlpHeader, 0, 0);
            this.tlpDasar.Controls.Add(this.pnlIsi, 0, 1);
            this.tlpDasar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDasar.Location = new System.Drawing.Point(0, 0);
            this.tlpDasar.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDasar.Name = "tlpDasar";
            this.tlpDasar.RowCount = 2;
            this.tlpDasar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.2158F));
            this.tlpDasar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.78419F));
            this.tlpDasar.Size = new System.Drawing.Size(1920, 1080);
            this.tlpDasar.TabIndex = 0;
            // 
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 1;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHeader.Controls.Add(this.pnlJudul, 0, 1);
            this.tlpHeader.Controls.Add(this.pnlMenu, 0, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 2;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeader.Size = new System.Drawing.Size(1920, 185);
            this.tlpHeader.TabIndex = 0;
            // 
            // pnlJudul
            // 
            this.pnlJudul.Controls.Add(this.tplJudul);
            this.pnlJudul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlJudul.Location = new System.Drawing.Point(0, 92);
            this.pnlJudul.Margin = new System.Windows.Forms.Padding(0);
            this.pnlJudul.Name = "pnlJudul";
            this.pnlJudul.Size = new System.Drawing.Size(1920, 93);
            this.pnlJudul.TabIndex = 1;
            // 
            // tplJudul
            // 
            this.tplJudul.ColumnCount = 1;
            this.tplJudul.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplJudul.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tplJudul.Controls.Add(this.lbJudul, 0, 0);
            this.tplJudul.Controls.Add(this.lbDeskripsi, 0, 1);
            this.tplJudul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplJudul.Location = new System.Drawing.Point(0, 0);
            this.tplJudul.Name = "tplJudul";
            this.tplJudul.RowCount = 2;
            this.tplJudul.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplJudul.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplJudul.Size = new System.Drawing.Size(1920, 93);
            this.tplJudul.TabIndex = 0;
            // 
            // lbJudul
            // 
            this.lbJudul.AutoSize = true;
            this.lbJudul.Font = new System.Drawing.Font("Plus Jakarta Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJudul.Location = new System.Drawing.Point(3, 0);
            this.lbJudul.Name = "lbJudul";
            this.lbJudul.Size = new System.Drawing.Size(75, 38);
            this.lbJudul.TabIndex = 0;
            this.lbJudul.Text = "Judul";
            // 
            // lbDeskripsi
            // 
            this.lbDeskripsi.AutoSize = true;
            this.lbDeskripsi.Font = new System.Drawing.Font("Plus Jakarta Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeskripsi.Location = new System.Drawing.Point(3, 46);
            this.lbDeskripsi.Name = "lbDeskripsi";
            this.lbDeskripsi.Size = new System.Drawing.Size(75, 24);
            this.lbDeskripsi.TabIndex = 1;
            this.lbDeskripsi.Text = "Deskripsi";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Black;
            this.pnlMenu.Controls.Add(this.tlpMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1920, 92);
            this.pnlMenu.TabIndex = 0;
            // 
            // tlpMenu
            // 
            this.tlpMenu.ColumnCount = 6;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.20833F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.739583F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.791667F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.82292F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMenu.Controls.Add(this.pbLogo, 0, 0);
            this.tlpMenu.Controls.Add(this.btnExit, 5, 0);
            this.tlpMenu.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tlpMenu.Controls.Add(this.btnKasir, 2, 0);
            this.tlpMenu.Controls.Add(this.btnRiwayat, 3, 0);
            this.tlpMenu.Controls.Add(this.tableLayoutPanel2, 4, 0);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenu.Location = new System.Drawing.Point(0, 0);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlpMenu.Size = new System.Drawing.Size(1920, 92);
            this.tlpMenu.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::Kasirku_Winforms.Properties.Resources.banyu_nobg;
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(314, 86);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BorderRadius = 11;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Plus Jakarta Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1669, 23);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 45);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Esc | Keluar";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlIsi
            // 
            this.pnlIsi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIsi.Location = new System.Drawing.Point(0, 185);
            this.pnlIsi.Margin = new System.Windows.Forms.Padding(0);
            this.pnlIsi.Name = "pnlIsi";
            this.pnlIsi.Size = new System.Drawing.Size(1920, 895);
            this.pnlIsi.TabIndex = 1;
            this.pnlIsi.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIsi_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbTanggal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbWaktu, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(320, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 92);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbTanggal
            // 
            this.lbTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTanggal.AutoSize = true;
            this.lbTanggal.Font = new System.Drawing.Font("Plus Jakarta Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTanggal.ForeColor = System.Drawing.Color.White;
            this.lbTanggal.Location = new System.Drawing.Point(3, 35);
            this.lbTanggal.Name = "lbTanggal";
            this.lbTanggal.Size = new System.Drawing.Size(45, 22);
            this.lbTanggal.TabIndex = 0;
            this.lbTanggal.Text = "label1";
            // 
            // lbWaktu
            // 
            this.lbWaktu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbWaktu.AutoSize = true;
            this.lbWaktu.Font = new System.Drawing.Font("Plus Jakarta Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaktu.ForeColor = System.Drawing.Color.White;
            this.lbWaktu.Location = new System.Drawing.Point(197, 35);
            this.lbWaktu.Name = "lbWaktu";
            this.lbWaktu.Size = new System.Drawing.Size(48, 22);
            this.lbWaktu.TabIndex = 1;
            this.lbWaktu.Text = "label2";
            // 
            // btnKasir
            // 
            this.btnKasir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnKasir.BorderRadius = 11;
            this.btnKasir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKasir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKasir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKasir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKasir.Font = new System.Drawing.Font("Plus Jakarta Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKasir.ForeColor = System.Drawing.Color.White;
            this.btnKasir.Location = new System.Drawing.Point(711, 23);
            this.btnKasir.Name = "btnKasir";
            this.btnKasir.Size = new System.Drawing.Size(180, 45);
            this.btnKasir.TabIndex = 3;
            this.btnKasir.Text = "F1 | Kasir";
            this.btnKasir.Click += new System.EventHandler(this.btnKasir_Click);
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRiwayat.BorderRadius = 11;
            this.btnRiwayat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRiwayat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRiwayat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRiwayat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRiwayat.Font = new System.Drawing.Font("Plus Jakarta Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiwayat.ForeColor = System.Drawing.Color.White;
            this.btnRiwayat.Location = new System.Drawing.Point(898, 23);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Size = new System.Drawing.Size(180, 45);
            this.btnRiwayat.TabIndex = 4;
            this.btnRiwayat.Text = "F2 | Riwayat";
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.guna2Button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.guna2Button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.guna2Button3, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1083, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(369, 92);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button1.BorderRadius = 11;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Plus Jakarta Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(3, 23);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(116, 45);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "F3 | Bayar";
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button2.BorderRadius = 11;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Plus Jakarta Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(125, 23);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(117, 45);
            this.guna2Button2.TabIndex = 5;
            this.guna2Button2.Text = "F4 | Struk";
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button3.BorderRadius = 11;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Plus Jakarta Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(248, 23);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(118, 45);
            this.guna2Button3.TabIndex = 6;
            this.guna2Button3.Text = "F5 | Reset";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.tlpDasar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.tlpDasar.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.pnlJudul.ResumeLayout(false);
            this.tplJudul.ResumeLayout(false);
            this.tplJudul.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.tlpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse el;
        private System.Windows.Forms.TableLayoutPanel tlpDasar;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.Panel pnlJudul;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlIsi;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tplJudul;
        private System.Windows.Forms.Label lbJudul;
        private System.Windows.Forms.Label lbDeskripsi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbTanggal;
        private System.Windows.Forms.Label lbWaktu;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btnKasir;
        private Guna.UI2.WinForms.Guna2Button btnRiwayat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}