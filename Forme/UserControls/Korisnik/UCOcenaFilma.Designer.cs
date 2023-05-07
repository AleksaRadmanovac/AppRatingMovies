using System.Windows.Forms;

namespace Forme.UserControls
{
    partial class UCOcenaFilma
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblZanr = new System.Windows.Forms.Label();
            this.listBoxUloge = new System.Windows.Forms.ListBox();
            this.lblUloge = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.txtFilmKomentar = new System.Windows.Forms.TextBox();
            this.txtKomentarUloga = new System.Windows.Forms.TextBox();
            this.btnOceni = new System.Windows.Forms.Button();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.grpBox2 = new System.Windows.Forms.GroupBox();
            this.lblNazad = new System.Windows.Forms.Label();
            this.lblGlumac = new System.Windows.Forms.Label();
            this.lblProsecnaOcena = new System.Windows.Forms.Label();
            this.listBoxOceneUloge = new System.Windows.Forms.ListBox();
            this.LblUlogaOcena = new System.Windows.Forms.Label();
            this.grpBox1.SuspendLayout();
            this.grpBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(164, 64);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(44, 16);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "label1";
            // 
            // lblZanr
            // 
            this.lblZanr.AutoSize = true;
            this.lblZanr.Location = new System.Drawing.Point(164, 112);
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
            this.listBoxUloge.Location = new System.Drawing.Point(168, 258);
            this.listBoxUloge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxUloge.Name = "listBoxUloge";
            this.listBoxUloge.Size = new System.Drawing.Size(317, 116);
            this.listBoxUloge.TabIndex = 3;
            this.listBoxUloge.SelectedIndexChanged += new System.EventHandler(this.listBoxUloge_SelectedIndexChanged);
            // 
            // lblUloge
            // 
            this.lblUloge.AutoSize = true;
            this.lblUloge.Location = new System.Drawing.Point(164, 239);
            this.lblUloge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUloge.Name = "lblUloge";
            this.lblUloge.Size = new System.Drawing.Size(44, 16);
            this.lblUloge.TabIndex = 4;
            this.lblUloge.Text = "Uloge";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 17);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 20);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(69, 17);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 20);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(119, 17);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(35, 20);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(169, 17);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(35, 20);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(219, 17);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(35, 20);
            this.radioButton5.TabIndex = 9;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(221, 22);
            this.radioButton10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(35, 20);
            this.radioButton10.TabIndex = 15;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "5";
            this.radioButton10.UseVisualStyleBackColor = false;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            this.radioButton10.Click += new System.EventHandler(this.radioButton10_Click);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(173, 22);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(35, 20);
            this.radioButton9.TabIndex = 14;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "4";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            this.radioButton9.Click += new System.EventHandler(this.radioButton9_Click);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(124, 22);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(35, 20);
            this.radioButton8.TabIndex = 13;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "3";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            this.radioButton8.Click += new System.EventHandler(this.radioButton8_Click);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(75, 22);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(35, 20);
            this.radioButton7.TabIndex = 12;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "2";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            this.radioButton7.Click += new System.EventHandler(this.radioButton7_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(25, 22);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(35, 20);
            this.radioButton6.TabIndex = 11;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "1";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            this.radioButton6.Click += new System.EventHandler(this.radioButton6_Click);
            // 
            // txtFilmKomentar
            // 
            this.txtFilmKomentar.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtFilmKomentar.Location = new System.Drawing.Point(584, 160);
            this.txtFilmKomentar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilmKomentar.Multiline = true;
            this.txtFilmKomentar.Name = "txtFilmKomentar";
            this.txtFilmKomentar.Size = new System.Drawing.Size(237, 64);
            this.txtFilmKomentar.TabIndex = 19;
            // 
            // txtKomentarUloga
            // 
            this.txtKomentarUloga.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtKomentarUloga.Enabled = false;
            this.txtKomentarUloga.Location = new System.Drawing.Point(584, 300);
            this.txtKomentarUloga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKomentarUloga.Multiline = true;
            this.txtKomentarUloga.Name = "txtKomentarUloga";
            this.txtKomentarUloga.Size = new System.Drawing.Size(237, 74);
            this.txtKomentarUloga.TabIndex = 20;
            this.txtKomentarUloga.Leave += new System.EventHandler(this.txtKomentarUloga_Leave);
            // 
            // btnOceni
            // 
            this.btnOceni.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnOceni.Location = new System.Drawing.Point(661, 418);
            this.btnOceni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOceni.Name = "btnOceni";
            this.btnOceni.Size = new System.Drawing.Size(161, 28);
            this.btnOceni.TabIndex = 21;
            this.btnOceni.Text = "Zavrsi ocenjivanje";
            this.btnOceni.UseVisualStyleBackColor = false;
            this.btnOceni.Click += new System.EventHandler(this.btnOceni_Click);
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.radioButton2);
            this.grpBox1.Controls.Add(this.radioButton1);
            this.grpBox1.Controls.Add(this.radioButton3);
            this.grpBox1.Controls.Add(this.radioButton5);
            this.grpBox1.Controls.Add(this.radioButton4);
            this.grpBox1.Location = new System.Drawing.Point(569, 84);
            this.grpBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox1.Size = new System.Drawing.Size(253, 44);
            this.grpBox1.TabIndex = 22;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Oceni Film";
            // 
            // grpBox2
            // 
            this.grpBox2.Controls.Add(this.radioButton6);
            this.grpBox2.Controls.Add(this.radioButton7);
            this.grpBox2.Controls.Add(this.radioButton8);
            this.grpBox2.Controls.Add(this.radioButton9);
            this.grpBox2.Controls.Add(this.radioButton10);
            this.grpBox2.Enabled = false;
            this.grpBox2.Location = new System.Drawing.Point(565, 242);
            this.grpBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox2.Name = "grpBox2";
            this.grpBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox2.Size = new System.Drawing.Size(257, 52);
            this.grpBox2.TabIndex = 23;
            this.grpBox2.TabStop = false;
            this.grpBox2.Text = "Oceni Ulogu";
            // 
            // lblNazad
            // 
            this.lblNazad.AutoSize = true;
            this.lblNazad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNazad.Location = new System.Drawing.Point(19, 16);
            this.lblNazad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNazad.Name = "lblNazad";
            this.lblNazad.Size = new System.Drawing.Size(61, 16);
            this.lblNazad.TabIndex = 24;
            this.lblNazad.Text = "<<Nazad";
            this.lblNazad.Visible = false;
            this.lblNazad.Click += new System.EventHandler(this.lblNazad_Click);
            // 
            // lblGlumac
            // 
            this.lblGlumac.AutoSize = true;
            this.lblGlumac.Enabled = false;
            this.lblGlumac.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGlumac.Location = new System.Drawing.Point(684, 379);
            this.lblGlumac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGlumac.Name = "lblGlumac";
            this.lblGlumac.Size = new System.Drawing.Size(130, 16);
            this.lblGlumac.TabIndex = 25;
            this.lblGlumac.Text = "Vise o ovom Glumcu";
            this.lblGlumac.Click += new System.EventHandler(this.lblGlumac_Click);
            // 
            // lblProsecnaOcena
            // 
            this.lblProsecnaOcena.AutoSize = true;
            this.lblProsecnaOcena.Location = new System.Drawing.Point(164, 177);
            this.lblProsecnaOcena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProsecnaOcena.Name = "lblProsecnaOcena";
            this.lblProsecnaOcena.Size = new System.Drawing.Size(112, 16);
            this.lblProsecnaOcena.TabIndex = 26;
            this.lblProsecnaOcena.Text = "Prosecna ocena: ";
            // 
            // listBoxOceneUloge
            // 
            this.listBoxOceneUloge.BackColor = System.Drawing.Color.NavajoWhite;
            this.listBoxOceneUloge.FormattingEnabled = true;
            this.listBoxOceneUloge.ItemHeight = 16;
            this.listBoxOceneUloge.Location = new System.Drawing.Point(483, 258);
            this.listBoxOceneUloge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxOceneUloge.Name = "listBoxOceneUloge";
            this.listBoxOceneUloge.Size = new System.Drawing.Size(36, 116);
            this.listBoxOceneUloge.TabIndex = 27;
            this.listBoxOceneUloge.Visible = false;
            // 
            // LblUlogaOcena
            // 
            this.LblUlogaOcena.AutoSize = true;
            this.LblUlogaOcena.Location = new System.Drawing.Point(479, 239);
            this.LblUlogaOcena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUlogaOcena.Name = "LblUlogaOcena";
            this.LblUlogaOcena.Size = new System.Drawing.Size(47, 16);
            this.LblUlogaOcena.TabIndex = 28;
            this.LblUlogaOcena.Text = "Ocena";
            this.LblUlogaOcena.Visible = false;
            // 
            // UCOcenaFilma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblUlogaOcena);
            this.Controls.Add(this.listBoxOceneUloge);
            this.Controls.Add(this.lblProsecnaOcena);
            this.Controls.Add(this.lblGlumac);
            this.Controls.Add(this.lblNazad);
            this.Controls.Add(this.grpBox2);
            this.Controls.Add(this.grpBox1);
            this.Controls.Add(this.btnOceni);
            this.Controls.Add(this.txtKomentarUloga);
            this.Controls.Add(this.txtFilmKomentar);
            this.Controls.Add(this.lblUloge);
            this.Controls.Add(this.listBoxUloge);
            this.Controls.Add(this.lblZanr);
            this.Controls.Add(this.lblNaziv);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCOcenaFilma";
            this.Size = new System.Drawing.Size(975, 500);
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.grpBox2.ResumeLayout(false);
            this.grpBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblZanr;
        private ListBox listBoxUloge;
        private Label lblUloge;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private TextBox txtFilmKomentar;
        private TextBox txtKomentarUloga;
        private Button btnOceni;
        private GroupBox grpBox1;
        private GroupBox grpBox2;
        private Label lblNazad;
        private Label lblGlumac;
        private Label lblProsecnaOcena;
        private ListBox listBoxOceneUloge;
        private Label LblUlogaOcena;

        public Label LblNaziv { get => lblNaziv; set => lblNaziv = value; }
        public Label LblZanr { get => lblZanr; set => lblZanr = value; }
        public ListBox ListBoxUloge { get => listBoxUloge; set => listBoxUloge = value; }
        public Label LblUloge { get => lblUloge; set => lblUloge = value; }
        public RadioButton RadioButton1 { get => radioButton1; set => radioButton1 = value; }
        public RadioButton RadioButton2 { get => radioButton2; set => radioButton2 = value; }
        public RadioButton RadioButton3 { get => radioButton3; set => radioButton3 = value; }
        public RadioButton RadioButton4 { get => radioButton4; set => radioButton4 = value; }
        public RadioButton RadioButton5 { get => radioButton5; set => radioButton5 = value; }
        public RadioButton RadioButton10 { get => radioButton10; set => radioButton10 = value; }
        public RadioButton RadioButton9 { get => radioButton9; set => radioButton9 = value; }
        public RadioButton RadioButton8 { get => radioButton8; set => radioButton8 = value; }
        public RadioButton RadioButton7 { get => radioButton7; set => radioButton7 = value; }
        public RadioButton RadioButton6 { get => radioButton6; set => radioButton6 = value; }
        public TextBox TxtFilmKomentar { get => txtFilmKomentar; set => txtFilmKomentar = value; }
        public TextBox TxtKomentarUloga { get => txtKomentarUloga; set => txtKomentarUloga = value; }
        public Button BtnOceni { get => btnOceni; set => btnOceni = value; }
        public GroupBox GrpBox1 { get => grpBox1; set => grpBox1 = value; }
        public GroupBox GrpBox2 { get => grpBox2; set => grpBox2 = value; }
        public Label LblNazad { get => lblNazad; set => lblNazad = value; }
        public Label LblGlumac { get => lblGlumac; set => lblGlumac = value; }
        public Label LblProsecnaOcena { get => lblProsecnaOcena; set => lblProsecnaOcena = value; }
        public ListBox ListBoxOceneUloge { get => listBoxOceneUloge; set => listBoxOceneUloge = value; }
        public Label LblUlogaOcena1 { get => LblUlogaOcena; set => LblUlogaOcena = value; }
    }
}
