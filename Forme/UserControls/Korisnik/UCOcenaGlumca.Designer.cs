using System.Windows.Forms;

namespace Forme.UserControls
{
    partial class UCOcenaGlumca
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblGodiste = new System.Windows.Forms.Label();
            this.lblPol = new System.Windows.Forms.Label();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.txtGlumacKomentar = new System.Windows.Forms.TextBox();
            this.lblFilmovi = new System.Windows.Forms.Label();
            this.listBoxFilmovi = new System.Windows.Forms.ListBox();
            this.btnOceni = new System.Windows.Forms.Button();
            this.lblNazad = new System.Windows.Forms.Label();
            this.lblProsecnaOcena = new System.Windows.Forms.Label();
            this.grpBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(124, 71);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(35, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "label1";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(124, 93);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(35, 13);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "label1";
            // 
            // lblGodiste
            // 
            this.lblGodiste.AutoSize = true;
            this.lblGodiste.Location = new System.Drawing.Point(124, 116);
            this.lblGodiste.Name = "lblGodiste";
            this.lblGodiste.Size = new System.Drawing.Size(35, 13);
            this.lblGodiste.TabIndex = 2;
            this.lblGodiste.Text = "label1";
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Location = new System.Drawing.Point(124, 138);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(35, 13);
            this.lblPol.TabIndex = 3;
            this.lblPol.Text = "label1";
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.radioButton2);
            this.grpBox1.Controls.Add(this.radioButton1);
            this.grpBox1.Controls.Add(this.radioButton3);
            this.grpBox1.Controls.Add(this.radioButton5);
            this.grpBox1.Controls.Add(this.radioButton4);
            this.grpBox1.Location = new System.Drawing.Point(426, 74);
            this.grpBox1.Margin = new System.Windows.Forms.Padding(2);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Padding = new System.Windows.Forms.Padding(2);
            this.grpBox1.Size = new System.Drawing.Size(190, 36);
            this.grpBox1.TabIndex = 24;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Oceni Glumca";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(52, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(89, 14);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(164, 14);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 9;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged_1);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(127, 14);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged_1);
            // 
            // txtGlumacKomentar
            // 
            this.txtGlumacKomentar.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtGlumacKomentar.Location = new System.Drawing.Point(437, 136);
            this.txtGlumacKomentar.Multiline = true;
            this.txtGlumacKomentar.Name = "txtGlumacKomentar";
            this.txtGlumacKomentar.Size = new System.Drawing.Size(179, 53);
            this.txtGlumacKomentar.TabIndex = 23;
            // 
            // lblFilmovi
            // 
            this.lblFilmovi.AutoSize = true;
            this.lblFilmovi.Location = new System.Drawing.Point(124, 192);
            this.lblFilmovi.Name = "lblFilmovi";
            this.lblFilmovi.Size = new System.Drawing.Size(39, 13);
            this.lblFilmovi.TabIndex = 26;
            this.lblFilmovi.Text = "Filmovi";
            // 
            // listBoxFilmovi
            // 
            this.listBoxFilmovi.BackColor = System.Drawing.Color.NavajoWhite;
            this.listBoxFilmovi.FormattingEnabled = true;
            this.listBoxFilmovi.Location = new System.Drawing.Point(127, 208);
            this.listBoxFilmovi.Name = "listBoxFilmovi";
            this.listBoxFilmovi.Size = new System.Drawing.Size(239, 95);
            this.listBoxFilmovi.TabIndex = 25;
            this.listBoxFilmovi.SelectedIndexChanged += new System.EventHandler(this.listBoxFilmovi_SelectedIndexChanged);
            // 
            // btnOceni
            // 
            this.btnOceni.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnOceni.Location = new System.Drawing.Point(495, 280);
            this.btnOceni.Name = "btnOceni";
            this.btnOceni.Size = new System.Drawing.Size(121, 23);
            this.btnOceni.TabIndex = 27;
            this.btnOceni.Text = "Zavrsi ocenjivanje";
            this.btnOceni.UseVisualStyleBackColor = false;
            this.btnOceni.Click += new System.EventHandler(this.btnOceni_Click_1);
            // 
            // lblNazad
            // 
            this.lblNazad.AutoSize = true;
            this.lblNazad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNazad.Location = new System.Drawing.Point(17, 18);
            this.lblNazad.Name = "lblNazad";
            this.lblNazad.Size = new System.Drawing.Size(50, 13);
            this.lblNazad.TabIndex = 28;
            this.lblNazad.Text = "<<Nazad";
            this.lblNazad.Visible = false;
            this.lblNazad.Click += new System.EventHandler(this.lblNazad_Click);
            // 
            // lblProsecnaOcena
            // 
            this.lblProsecnaOcena.AutoSize = true;
            this.lblProsecnaOcena.Location = new System.Drawing.Point(124, 164);
            this.lblProsecnaOcena.Name = "lblProsecnaOcena";
            this.lblProsecnaOcena.Size = new System.Drawing.Size(91, 13);
            this.lblProsecnaOcena.TabIndex = 29;
            this.lblProsecnaOcena.Text = "Prosecna ocena: ";
            // 
            // UCOcenaGlumca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProsecnaOcena);
            this.Controls.Add(this.lblNazad);
            this.Controls.Add(this.btnOceni);
            this.Controls.Add(this.lblFilmovi);
            this.Controls.Add(this.listBoxFilmovi);
            this.Controls.Add(this.grpBox1);
            this.Controls.Add(this.txtGlumacKomentar);
            this.Controls.Add(this.lblPol);
            this.Controls.Add(this.lblGodiste);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Name = "UCOcenaGlumca";
            this.Size = new System.Drawing.Size(732, 407);
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblGodiste;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox txtGlumacKomentar;
        private System.Windows.Forms.Label lblFilmovi;
        private System.Windows.Forms.ListBox listBoxFilmovi;
        private Button btnOceni;
        private Label lblNazad;
        private Label lblProsecnaOcena;

        public Label LblIme { get => lblIme; set => lblIme = value; }
        public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
        public Label LblGodiste { get => lblGodiste; set => lblGodiste = value; }
        public Label LblPol { get => lblPol; set => lblPol = value; }
        public GroupBox GrpBox1 { get => grpBox1; set => grpBox1 = value; }
        public RadioButton RadioButton2 { get => radioButton2; set => radioButton2 = value; }
        public RadioButton RadioButton1 { get => radioButton1; set => radioButton1 = value; }
        public RadioButton RadioButton3 { get => radioButton3; set => radioButton3 = value; }
        public RadioButton RadioButton5 { get => radioButton5; set => radioButton5 = value; }
        public RadioButton RadioButton4 { get => radioButton4; set => radioButton4 = value; }
        public TextBox TxtGlumacKomentar { get => txtGlumacKomentar; set => txtGlumacKomentar = value; }
        public Label LblFilmovi { get => lblFilmovi; set => lblFilmovi = value; }
        public ListBox ListBoxFilmovi { get => listBoxFilmovi; set => listBoxFilmovi = value; }
        public Button BtnOceni { get => btnOceni; set => btnOceni = value; }
        public Label LblNazad { get => lblNazad; set => lblNazad = value; }
        public Label LblProsecnaOcena { get => lblProsecnaOcena; set => lblProsecnaOcena = value; }
    }
}
