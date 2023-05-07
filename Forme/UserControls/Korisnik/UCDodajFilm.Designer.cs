using System.Windows.Forms;

namespace Forme.UserControls
{
    partial class UCDodajFilm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBoxNaziv = new System.Windows.Forms.TextBox();
            this.cmbBoxZanr = new System.Windows.Forms.ComboBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblZanr = new System.Windows.Forms.Label();
            this.dgvGlumci = new System.Windows.Forms.DataGridView();
            this.txtBoxPretraga = new System.Windows.Forms.TextBox();
            this.txtBoxGlumac = new System.Windows.Forms.TextBox();
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.lblGlumac = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxImeUloge = new System.Windows.Forms.TextBox();
            this.lblImeUloge = new System.Windows.Forms.Label();
            this.btnDodajUlogu = new System.Windows.Forms.Button();
            this.chkBoxJeGlavna = new System.Windows.Forms.CheckBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKraj = new System.Windows.Forms.Button();
            this.dgvPretragaFilmova = new System.Windows.Forms.DataGridView();
            this.lblPretraziFilmove = new System.Windows.Forms.Label();
            this.txtBoxPretraziFilmove = new System.Windows.Forms.TextBox();
            this.btnPretraziFilmove = new System.Windows.Forms.Button();
            this.lblDodajGlumcaPitanje = new System.Windows.Forms.Label();
            this.lblDodajGlumca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlumci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretragaFilmova)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxNaziv
            // 
            this.txtBoxNaziv.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtBoxNaziv.Location = new System.Drawing.Point(52, 49);
            this.txtBoxNaziv.Name = "txtBoxNaziv";
            this.txtBoxNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNaziv.TabIndex = 0;
            // 
            // cmbBoxZanr
            // 
            this.cmbBoxZanr.BackColor = System.Drawing.Color.NavajoWhite;
            this.cmbBoxZanr.FormattingEnabled = true;
            this.cmbBoxZanr.Location = new System.Drawing.Point(52, 88);
            this.cmbBoxZanr.Name = "cmbBoxZanr";
            this.cmbBoxZanr.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxZanr.TabIndex = 1;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(54, 30);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 2;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblZanr
            // 
            this.lblZanr.AutoSize = true;
            this.lblZanr.Location = new System.Drawing.Point(54, 72);
            this.lblZanr.Name = "lblZanr";
            this.lblZanr.Size = new System.Drawing.Size(29, 13);
            this.lblZanr.TabIndex = 3;
            this.lblZanr.Text = "Zanr";
            // 
            // dgvGlumci
            // 
            this.dgvGlumci.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvGlumci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGlumci.Enabled = false;
            this.dgvGlumci.GridColor = System.Drawing.Color.NavajoWhite;
            this.dgvGlumci.Location = new System.Drawing.Point(417, 215);
            this.dgvGlumci.Name = "dgvGlumci";
            this.dgvGlumci.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGlumci.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            this.dgvGlumci.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGlumci.Size = new System.Drawing.Size(308, 150);
            this.dgvGlumci.TabIndex = 4;
            this.dgvGlumci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGlumci_CellClick);
            this.dgvGlumci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGlumci_CellDoubleClick);
            this.dgvGlumci.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGlumci_CellMouseClick);
            // 
            // txtBoxPretraga
            // 
            this.txtBoxPretraga.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtBoxPretraga.Enabled = false;
            this.txtBoxPretraga.Location = new System.Drawing.Point(417, 189);
            this.txtBoxPretraga.Name = "txtBoxPretraga";
            this.txtBoxPretraga.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPretraga.TabIndex = 5;
            // 
            // txtBoxGlumac
            // 
            this.txtBoxGlumac.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtBoxGlumac.Enabled = false;
            this.txtBoxGlumac.Location = new System.Drawing.Point(417, 49);
            this.txtBoxGlumac.Name = "txtBoxGlumac";
            this.txtBoxGlumac.Size = new System.Drawing.Size(100, 20);
            this.txtBoxGlumac.TabIndex = 6;
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.Enabled = false;
            this.lblPretrazi.Location = new System.Drawing.Point(417, 173);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(81, 13);
            this.lblPretrazi.TabIndex = 7;
            this.lblPretrazi.Text = "Pretrazi Glumce";
            // 
            // lblGlumac
            // 
            this.lblGlumac.AutoSize = true;
            this.lblGlumac.Enabled = false;
            this.lblGlumac.Location = new System.Drawing.Point(417, 30);
            this.lblGlumac.Name = "lblGlumac";
            this.lblGlumac.Size = new System.Drawing.Size(43, 13);
            this.lblGlumac.TabIndex = 8;
            this.lblGlumac.Text = "Glumac";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Uloge";
            // 
            // txtBoxImeUloge
            // 
            this.txtBoxImeUloge.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtBoxImeUloge.Enabled = false;
            this.txtBoxImeUloge.Location = new System.Drawing.Point(417, 88);
            this.txtBoxImeUloge.Name = "txtBoxImeUloge";
            this.txtBoxImeUloge.Size = new System.Drawing.Size(100, 20);
            this.txtBoxImeUloge.TabIndex = 10;
            // 
            // lblImeUloge
            // 
            this.lblImeUloge.AutoSize = true;
            this.lblImeUloge.Enabled = false;
            this.lblImeUloge.Location = new System.Drawing.Point(417, 72);
            this.lblImeUloge.Name = "lblImeUloge";
            this.lblImeUloge.Size = new System.Drawing.Size(53, 13);
            this.lblImeUloge.TabIndex = 11;
            this.lblImeUloge.Text = "Ime uloge";
            // 
            // btnDodajUlogu
            // 
            this.btnDodajUlogu.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnDodajUlogu.Enabled = false;
            this.btnDodajUlogu.Location = new System.Drawing.Point(417, 138);
            this.btnDodajUlogu.Name = "btnDodajUlogu";
            this.btnDodajUlogu.Size = new System.Drawing.Size(75, 23);
            this.btnDodajUlogu.TabIndex = 12;
            this.btnDodajUlogu.Text = "Dodaj Ulogu";
            this.btnDodajUlogu.UseVisualStyleBackColor = false;
            this.btnDodajUlogu.Click += new System.EventHandler(this.btnDodajUlogu_Click);
            // 
            // chkBoxJeGlavna
            // 
            this.chkBoxJeGlavna.AutoSize = true;
            this.chkBoxJeGlavna.BackColor = System.Drawing.Color.SandyBrown;
            this.chkBoxJeGlavna.Enabled = false;
            this.chkBoxJeGlavna.Location = new System.Drawing.Point(417, 115);
            this.chkBoxJeGlavna.Name = "chkBoxJeGlavna";
            this.chkBoxJeGlavna.Size = new System.Drawing.Size(91, 17);
            this.chkBoxJeGlavna.TabIndex = 13;
            this.chkBoxJeGlavna.Text = "Glavna Uloga";
            this.chkBoxJeGlavna.UseVisualStyleBackColor = false;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnPretrazi.Enabled = false;
            this.btnPretrazi.Location = new System.Drawing.Point(523, 189);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(77, 20);
            this.btnPretrazi.TabIndex = 14;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Film";
            // 
            // btnKraj
            // 
            this.btnKraj.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnKraj.Location = new System.Drawing.Point(337, 371);
            this.btnKraj.Name = "btnKraj";
            this.btnKraj.Size = new System.Drawing.Size(105, 23);
            this.btnKraj.TabIndex = 16;
            this.btnKraj.Text = "Zavrsi sa unosom";
            this.btnKraj.UseVisualStyleBackColor = false;
            this.btnKraj.Click += new System.EventHandler(this.btnKraj_Click);
            // 
            // dgvPretragaFilmova
            // 
            this.dgvPretragaFilmova.AllowUserToAddRows = false;
            this.dgvPretragaFilmova.AllowUserToDeleteRows = false;
            this.dgvPretragaFilmova.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvPretragaFilmova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretragaFilmova.GridColor = System.Drawing.Color.NavajoWhite;
            this.dgvPretragaFilmova.Location = new System.Drawing.Point(49, 215);
            this.dgvPretragaFilmova.Name = "dgvPretragaFilmova";
            this.dgvPretragaFilmova.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPretragaFilmova.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.NavajoWhite;
            this.dgvPretragaFilmova.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPretragaFilmova.Size = new System.Drawing.Size(308, 150);
            this.dgvPretragaFilmova.TabIndex = 18;
            this.dgvPretragaFilmova.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretragaFilmova_CellClick);
            this.dgvPretragaFilmova.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretragaFilmova_CellContentClick);
            // 
            // lblPretraziFilmove
            // 
            this.lblPretraziFilmove.AutoSize = true;
            this.lblPretraziFilmove.Location = new System.Drawing.Point(46, 173);
            this.lblPretraziFilmove.Name = "lblPretraziFilmove";
            this.lblPretraziFilmove.Size = new System.Drawing.Size(88, 13);
            this.lblPretraziFilmove.TabIndex = 19;
            this.lblPretraziFilmove.Text = "Dodaj ulogu filmu";
            // 
            // txtBoxPretraziFilmove
            // 
            this.txtBoxPretraziFilmove.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtBoxPretraziFilmove.Location = new System.Drawing.Point(49, 189);
            this.txtBoxPretraziFilmove.Name = "txtBoxPretraziFilmove";
            this.txtBoxPretraziFilmove.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPretraziFilmove.TabIndex = 20;
            // 
            // btnPretraziFilmove
            // 
            this.btnPretraziFilmove.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnPretraziFilmove.Location = new System.Drawing.Point(155, 189);
            this.btnPretraziFilmove.Name = "btnPretraziFilmove";
            this.btnPretraziFilmove.Size = new System.Drawing.Size(77, 20);
            this.btnPretraziFilmove.TabIndex = 21;
            this.btnPretraziFilmove.Text = "Pretrazi";
            this.btnPretraziFilmove.UseVisualStyleBackColor = false;
            this.btnPretraziFilmove.Click += new System.EventHandler(this.btnPretraziFilmove_Click);
            // 
            // lblDodajGlumcaPitanje
            // 
            this.lblDodajGlumcaPitanje.AutoSize = true;
            this.lblDodajGlumcaPitanje.Location = new System.Drawing.Point(520, 30);
            this.lblDodajGlumcaPitanje.Name = "lblDodajGlumcaPitanje";
            this.lblDodajGlumcaPitanje.Size = new System.Drawing.Size(249, 13);
            this.lblDodajGlumcaPitanje.TabIndex = 23;
            this.lblDodajGlumcaPitanje.Text = "U programu ne postoji glumac koji je glumio u flimu?";
            // 
            // lblDodajGlumca
            // 
            this.lblDodajGlumca.AutoSize = true;
            this.lblDodajGlumca.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDodajGlumca.Location = new System.Drawing.Point(568, 47);
            this.lblDodajGlumca.Name = "lblDodajGlumca";
            this.lblDodajGlumca.Size = new System.Drawing.Size(155, 13);
            this.lblDodajGlumca.TabIndex = 24;
            this.lblDodajGlumca.Text = "Podnesi zahtev za njegov unos";
            this.lblDodajGlumca.Click += new System.EventHandler(this.lblDodajGlumca_Click);
            // 
            // UCDodajFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDodajGlumca);
            this.Controls.Add(this.lblDodajGlumcaPitanje);
            this.Controls.Add(this.btnPretraziFilmove);
            this.Controls.Add(this.txtBoxPretraziFilmove);
            this.Controls.Add(this.lblPretraziFilmove);
            this.Controls.Add(this.dgvPretragaFilmova);
            this.Controls.Add(this.btnKraj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.chkBoxJeGlavna);
            this.Controls.Add(this.btnDodajUlogu);
            this.Controls.Add(this.lblImeUloge);
            this.Controls.Add(this.txtBoxImeUloge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGlumac);
            this.Controls.Add(this.lblPretrazi);
            this.Controls.Add(this.txtBoxGlumac);
            this.Controls.Add(this.txtBoxPretraga);
            this.Controls.Add(this.dgvGlumci);
            this.Controls.Add(this.lblZanr);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.cmbBoxZanr);
            this.Controls.Add(this.txtBoxNaziv);
            this.Name = "UCDodajFilm";
            this.Size = new System.Drawing.Size(774, 402);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlumci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretragaFilmova)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNaziv;
        private System.Windows.Forms.ComboBox cmbBoxZanr;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblZanr;
        private System.Windows.Forms.DataGridView dgvGlumci;
        private System.Windows.Forms.TextBox txtBoxPretraga;
        private System.Windows.Forms.TextBox txtBoxGlumac;
        private System.Windows.Forms.Label lblPretrazi;
        private System.Windows.Forms.Label lblGlumac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxImeUloge;
        private System.Windows.Forms.Label lblImeUloge;
        private System.Windows.Forms.Button btnDodajUlogu;
        private System.Windows.Forms.CheckBox chkBoxJeGlavna;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label label5;
        private Button btnKraj;
        private DataGridView dgvPretragaFilmova;
        private Label lblPretraziFilmove;
        private TextBox txtBoxPretraziFilmove;
        private Button btnPretraziFilmove;
        private Label lblDodajGlumcaPitanje;
        private Label lblDodajGlumca;

        public TextBox TxtBoxNaziv { get => txtBoxNaziv; set => txtBoxNaziv = value; }
        public ComboBox CmbBoxZanr { get => cmbBoxZanr; set => cmbBoxZanr = value; }
        public Label LblNaziv { get => lblNaziv; set => lblNaziv = value; }
        public Label LblZanr { get => lblZanr; set => lblZanr = value; }
        public DataGridView DgvGlumci { get => dgvGlumci; set => dgvGlumci = value; }
        public TextBox TxtBoxPretraga { get => txtBoxPretraga; set => txtBoxPretraga = value; }
        public TextBox TxtBoxGlumac { get => txtBoxGlumac; set => txtBoxGlumac = value; }
        public Label LblPretrazi { get => lblPretrazi; set => lblPretrazi = value; }
        public Label LblGlumac { get => lblGlumac; set => lblGlumac = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public TextBox TxtBoxImeUloge { get => txtBoxImeUloge; set => txtBoxImeUloge = value; }
        public Label LblImeUloge { get => lblImeUloge; set => lblImeUloge = value; }
        public Button BtnDodajUlogu { get => btnDodajUlogu; set => btnDodajUlogu = value; }
        public CheckBox ChkBoxJeGlavna { get => chkBoxJeGlavna; set => chkBoxJeGlavna = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Button BtnKraj { get => btnKraj; set => btnKraj = value; }
        public DataGridView DgvPretragaFilmova { get => dgvPretragaFilmova; set => dgvPretragaFilmova = value; }
        public Label LblPretraziFilmove { get => lblPretraziFilmove; set => lblPretraziFilmove = value; }
        public TextBox TxtBoxPretraziFilmove { get => txtBoxPretraziFilmove; set => txtBoxPretraziFilmove = value; }
        public Button BtnPretraziFilmove { get => btnPretraziFilmove; set => btnPretraziFilmove = value; }
    }
}
