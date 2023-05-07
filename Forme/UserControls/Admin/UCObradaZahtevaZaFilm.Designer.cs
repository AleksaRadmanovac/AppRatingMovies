using System.Windows.Forms;

namespace Forme.UserControls.Admin
{
    partial class UCObradaZahtevaZaFilm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblZanr = new System.Windows.Forms.Label();
            this.listBoxUloge = new System.Windows.Forms.ListBox();
            this.lblViseOGlumcu = new System.Windows.Forms.Label();
            this.lblUloge = new System.Windows.Forms.Label();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.btnOdobri = new System.Windows.Forms.Button();
            this.btnDodajUlogePocetak = new System.Windows.Forms.Button();
            this.lblIzmeni = new System.Windows.Forms.Label();
            this.lblProveri = new System.Windows.Forms.Label();
            this.txtBoxPretraga = new System.Windows.Forms.TextBox();
            this.lblOdaberiFilm = new System.Windows.Forms.Label();
            this.dgvPretraga = new System.Windows.Forms.DataGridView();
            this.lblViseOFilmu = new System.Windows.Forms.Label();
            this.chkListBoxUloge = new System.Windows.Forms.CheckedListBox();
            this.btnOdbij = new System.Windows.Forms.Button();
            this.btnDodajUlogeKraj = new System.Windows.Forms.Button();
            this.pnlDodajUloge = new System.Windows.Forms.Panel();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.lblDodajUloge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            this.pnlDodajUloge.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(61, 71);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(35, 16);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Film:";
            // 
            // lblZanr
            // 
            this.lblZanr.AutoSize = true;
            this.lblZanr.Location = new System.Drawing.Point(61, 108);
            this.lblZanr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZanr.Name = "lblZanr";
            this.lblZanr.Size = new System.Drawing.Size(40, 16);
            this.lblZanr.TabIndex = 1;
            this.lblZanr.Text = "Zanr: ";
            // 
            // listBoxUloge
            // 
            this.listBoxUloge.BackColor = System.Drawing.Color.NavajoWhite;
            this.listBoxUloge.FormattingEnabled = true;
            this.listBoxUloge.ItemHeight = 16;
            this.listBoxUloge.Location = new System.Drawing.Point(65, 176);
            this.listBoxUloge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxUloge.Name = "listBoxUloge";
            this.listBoxUloge.Size = new System.Drawing.Size(278, 116);
            this.listBoxUloge.TabIndex = 2;
            // 
            // lblViseOGlumcu
            // 
            this.lblViseOGlumcu.AutoSize = true;
            this.lblViseOGlumcu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblViseOGlumcu.Location = new System.Drawing.Point(252, 296);
            this.lblViseOGlumcu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViseOGlumcu.Name = "lblViseOGlumcu";
            this.lblViseOGlumcu.Size = new System.Drawing.Size(91, 16);
            this.lblViseOGlumcu.TabIndex = 7;
            this.lblViseOGlumcu.Text = "Vise o glumcu";
            this.lblViseOGlumcu.Click += new System.EventHandler(this.lblViseOGlumcu_Click);
            // 
            // lblUloge
            // 
            this.lblUloge.AutoSize = true;
            this.lblUloge.Location = new System.Drawing.Point(61, 156);
            this.lblUloge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUloge.Name = "lblUloge";
            this.lblUloge.Size = new System.Drawing.Size(47, 16);
            this.lblUloge.TabIndex = 8;
            this.lblUloge.Text = "Uloge:";
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(61, 441);
            this.lblPretraga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(372, 16);
            this.lblPretraga.TabIndex = 9;
            this.lblPretraga.Text = "Mozda je film vec u bazi? Nisi siguran koji glumac je u pitanju?";
            // 
            // btnOdobri
            // 
            this.btnOdobri.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnOdobri.Location = new System.Drawing.Point(65, 357);
            this.btnOdobri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(100, 60);
            this.btnOdobri.TabIndex = 10;
            this.btnOdobri.Text = "Odobri unos novog filma";
            this.btnOdobri.UseVisualStyleBackColor = false;
            this.btnOdobri.Click += new System.EventHandler(this.btnOdobri_Click);
            // 
            // btnDodajUlogePocetak
            // 
            this.btnDodajUlogePocetak.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnDodajUlogePocetak.Location = new System.Drawing.Point(377, 74);
            this.btnDodajUlogePocetak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajUlogePocetak.Name = "btnDodajUlogePocetak";
            this.btnDodajUlogePocetak.Size = new System.Drawing.Size(211, 27);
            this.btnDodajUlogePocetak.TabIndex = 11;
            this.btnDodajUlogePocetak.Text = "Dodaj uloge u postojeci film";
            this.btnDodajUlogePocetak.UseVisualStyleBackColor = false;
            this.btnDodajUlogePocetak.Click += new System.EventHandler(this.btnDodajUlogePocetak_Click);
            // 
            // lblIzmeni
            // 
            this.lblIzmeni.AutoSize = true;
            this.lblIzmeni.Location = new System.Drawing.Point(95, 293);
            this.lblIzmeni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIzmeni.Name = "lblIzmeni";
            this.lblIzmeni.Size = new System.Drawing.Size(173, 16);
            this.lblIzmeni.TabIndex = 12;
            this.lblIzmeni.Text = "Koje uloge zelite da dodate:";
            // 
            // lblProveri
            // 
            this.lblProveri.AutoSize = true;
            this.lblProveri.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblProveri.Location = new System.Drawing.Point(395, 468);
            this.lblProveri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveri.Name = "lblProveri";
            this.lblProveri.Size = new System.Drawing.Size(59, 16);
            this.lblProveri.TabIndex = 13;
            this.lblProveri.Text = "Proveri...";
            this.lblProveri.Click += new System.EventHandler(this.lblProveri_Click);
            // 
            // txtBoxPretraga
            // 
            this.txtBoxPretraga.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtBoxPretraga.Location = new System.Drawing.Point(15, 27);
            this.txtBoxPretraga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPretraga.Name = "txtBoxPretraga";
            this.txtBoxPretraga.Size = new System.Drawing.Size(247, 22);
            this.txtBoxPretraga.TabIndex = 14;
            // 
            // lblOdaberiFilm
            // 
            this.lblOdaberiFilm.AutoSize = true;
            this.lblOdaberiFilm.Location = new System.Drawing.Point(11, 10);
            this.lblOdaberiFilm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdaberiFilm.Name = "lblOdaberiFilm";
            this.lblOdaberiFilm.Size = new System.Drawing.Size(241, 16);
            this.lblOdaberiFilm.TabIndex = 15;
            this.lblOdaberiFilm.Text = "Odaberi film u koji zelis da dodas uloge";
            // 
            // dgvPretraga
            // 
            this.dgvPretraga.AllowUserToAddRows = false;
            this.dgvPretraga.AllowUserToDeleteRows = false;
            this.dgvPretraga.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretraga.GridColor = System.Drawing.Color.NavajoWhite;
            this.dgvPretraga.Location = new System.Drawing.Point(15, 64);
            this.dgvPretraga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPretraga.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPretraga.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            this.dgvPretraga.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPretraga.Size = new System.Drawing.Size(333, 185);
            this.dgvPretraga.TabIndex = 16;
            // 
            // lblViseOFilmu
            // 
            this.lblViseOFilmu.AutoSize = true;
            this.lblViseOFilmu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblViseOFilmu.Location = new System.Drawing.Point(268, 252);
            this.lblViseOFilmu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViseOFilmu.Name = "lblViseOFilmu";
            this.lblViseOFilmu.Size = new System.Drawing.Size(75, 16);
            this.lblViseOFilmu.TabIndex = 17;
            this.lblViseOFilmu.Text = "Vise o filmu";
            this.lblViseOFilmu.Click += new System.EventHandler(this.lblViseOFilmu_Click);
            // 
            // chkListBoxUloge
            // 
            this.chkListBoxUloge.BackColor = System.Drawing.Color.NavajoWhite;
            this.chkListBoxUloge.FormattingEnabled = true;
            this.chkListBoxUloge.Location = new System.Drawing.Point(98, 313);
            this.chkListBoxUloge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkListBoxUloge.Name = "chkListBoxUloge";
            this.chkListBoxUloge.Size = new System.Drawing.Size(250, 106);
            this.chkListBoxUloge.TabIndex = 18;
            // 
            // btnOdbij
            // 
            this.btnOdbij.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnOdbij.Location = new System.Drawing.Point(213, 357);
            this.btnOdbij.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOdbij.Name = "btnOdbij";
            this.btnOdbij.Size = new System.Drawing.Size(100, 60);
            this.btnOdbij.TabIndex = 19;
            this.btnOdbij.Text = "Odbij zahtev";
            this.btnOdbij.UseVisualStyleBackColor = false;
            this.btnOdbij.Click += new System.EventHandler(this.btnOdbij_Click);
            // 
            // btnDodajUlogeKraj
            // 
            this.btnDodajUlogeKraj.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnDodajUlogeKraj.Location = new System.Drawing.Point(360, 357);
            this.btnDodajUlogeKraj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajUlogeKraj.Name = "btnDodajUlogeKraj";
            this.btnDodajUlogeKraj.Size = new System.Drawing.Size(100, 60);
            this.btnDodajUlogeKraj.TabIndex = 20;
            this.btnDodajUlogeKraj.Text = "Dodaj Uloge";
            this.btnDodajUlogeKraj.UseVisualStyleBackColor = false;
            this.btnDodajUlogeKraj.Visible = false;
            this.btnDodajUlogeKraj.Click += new System.EventHandler(this.btnDodajUlogeKraj_Click);
            // 
            // pnlDodajUloge
            // 
            this.pnlDodajUloge.Controls.Add(this.btnPretraga);
            this.pnlDodajUloge.Controls.Add(this.txtBoxPretraga);
            this.pnlDodajUloge.Controls.Add(this.lblOdaberiFilm);
            this.pnlDodajUloge.Controls.Add(this.dgvPretraga);
            this.pnlDodajUloge.Controls.Add(this.chkListBoxUloge);
            this.pnlDodajUloge.Controls.Add(this.lblIzmeni);
            this.pnlDodajUloge.Controls.Add(this.lblViseOFilmu);
            this.pnlDodajUloge.Location = new System.Drawing.Point(596, 44);
            this.pnlDodajUloge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDodajUloge.Name = "pnlDodajUloge";
            this.pnlDodajUloge.Size = new System.Drawing.Size(408, 465);
            this.pnlDodajUloge.TabIndex = 21;
            this.pnlDodajUloge.Visible = false;
            // 
            // btnPretraga
            // 
            this.btnPretraga.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnPretraga.Location = new System.Drawing.Point(271, 27);
            this.btnPretraga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(77, 25);
            this.btnPretraga.TabIndex = 19;
            this.btnPretraga.Text = "Pretrazi";
            this.btnPretraga.UseVisualStyleBackColor = false;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // lblDodajUloge
            // 
            this.lblDodajUloge.AutoSize = true;
            this.lblDodajUloge.Location = new System.Drawing.Point(272, 54);
            this.lblDodajUloge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDodajUloge.Name = "lblDodajUloge";
            this.lblDodajUloge.Size = new System.Drawing.Size(298, 16);
            this.lblDodajUloge.TabIndex = 22;
            this.lblDodajUloge.Text = "Korisnik zeli da doda uloge za vec postojeci film?";
            // 
            // UCObradaZahtevaZaFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDodajUloge);
            this.Controls.Add(this.pnlDodajUloge);
            this.Controls.Add(this.btnDodajUlogeKraj);
            this.Controls.Add(this.btnOdbij);
            this.Controls.Add(this.lblProveri);
            this.Controls.Add(this.btnDodajUlogePocetak);
            this.Controls.Add(this.btnOdobri);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.lblUloge);
            this.Controls.Add(this.lblViseOGlumcu);
            this.Controls.Add(this.listBoxUloge);
            this.Controls.Add(this.lblZanr);
            this.Controls.Add(this.lblNaziv);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCObradaZahtevaZaFilm";
            this.Size = new System.Drawing.Size(1048, 527);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).EndInit();
            this.pnlDodajUloge.ResumeLayout(false);
            this.pnlDodajUloge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblZanr;
        private System.Windows.Forms.ListBox listBoxUloge;
        private System.Windows.Forms.Label lblViseOGlumcu;
        private System.Windows.Forms.Label lblUloge;
        private Label lblPretraga;
        private Button btnOdobri;
        private Button btnDodajUlogePocetak;
        private Label lblIzmeni;
        private Label lblProveri;
        private TextBox txtBoxPretraga;
        private Label lblOdaberiFilm;
        private DataGridView dgvPretraga;
        private Label lblViseOFilmu;
        private CheckedListBox chkListBoxUloge;
        private Button btnOdbij;
        private Button btnDodajUlogeKraj;
        private Panel pnlDodajUloge;
        private Label lblDodajUloge;
        private Button btnPretraga;

        public Label LblNaziv { get => lblNaziv; set => lblNaziv = value; }
        public Label LblZanr { get => lblZanr; set => lblZanr = value; }
        public ListBox ListBoxUloge { get => listBoxUloge; set => listBoxUloge = value; }
        public Label LblViseOGlumcu { get => lblViseOGlumcu; set => lblViseOGlumcu = value; }
        public Label LblUloge { get => lblUloge; set => lblUloge = value; }
        public Label LblPretraga { get => lblPretraga; set => lblPretraga = value; }
        public Button BtnOdobri { get => btnOdobri; set => btnOdobri = value; }
        public Button BtnDodajUlogePocetak { get => btnDodajUlogePocetak; set => btnDodajUlogePocetak = value; }
        public Label LblIzmeni { get => lblIzmeni; set => lblIzmeni = value; }
        public Label LblProveri { get => lblProveri; set => lblProveri = value; }
        public TextBox TxtBoxPretraga { get => txtBoxPretraga; set => txtBoxPretraga = value; }
        public Label LblOdaberiFilm { get => lblOdaberiFilm; set => lblOdaberiFilm = value; }
        public DataGridView DgvPretraga { get => dgvPretraga; set => dgvPretraga = value; }
        public Label LblViseOFilmu { get => lblViseOFilmu; set => lblViseOFilmu = value; }
        public CheckedListBox ChkListBoxUloge { get => chkListBoxUloge; set => chkListBoxUloge = value; }
        public Button BtnOdbij { get => btnOdbij; set => btnOdbij = value; }
        public Button BtnDodajUlogeKraj { get => btnDodajUlogeKraj; set => btnDodajUlogeKraj = value; }
        public Panel PnlDodajUloge { get => pnlDodajUloge; set => pnlDodajUloge = value; }
    }
}
