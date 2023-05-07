using System.Windows.Forms;

namespace Forme.UserControls
{
    partial class UCDodajGlumca
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.txtGodiste = new System.Windows.Forms.TextBox();
            this.cmbBoxPol = new System.Windows.Forms.ComboBox();
            this.btnPodnesi = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblGodiste = new System.Windows.Forms.Label();
            this.lblPol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtIme.Location = new System.Drawing.Point(49, 74);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 0;
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtBoxPrezime.Location = new System.Drawing.Point(49, 113);
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrezime.TabIndex = 1;
            // 
            // txtGodiste
            // 
            this.txtGodiste.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtGodiste.Location = new System.Drawing.Point(49, 151);
            this.txtGodiste.Name = "txtGodiste";
            this.txtGodiste.Size = new System.Drawing.Size(100, 20);
            this.txtGodiste.TabIndex = 2;
            this.txtGodiste.TextChanged += new System.EventHandler(this.txtGodiste_TextChanged);
            // 
            // cmbBoxPol
            // 
            this.cmbBoxPol.BackColor = System.Drawing.Color.NavajoWhite;
            this.cmbBoxPol.FormattingEnabled = true;
            this.cmbBoxPol.Location = new System.Drawing.Point(49, 190);
            this.cmbBoxPol.Name = "cmbBoxPol";
            this.cmbBoxPol.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxPol.TabIndex = 3;
            // 
            // btnPodnesi
            // 
            this.btnPodnesi.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnPodnesi.Location = new System.Drawing.Point(49, 228);
            this.btnPodnesi.Name = "btnPodnesi";
            this.btnPodnesi.Size = new System.Drawing.Size(121, 23);
            this.btnPodnesi.TabIndex = 4;
            this.btnPodnesi.Text = "Podnesi Zahtev";
            this.btnPodnesi.UseVisualStyleBackColor = false;
            this.btnPodnesi.Click += new System.EventHandler(this.btnPodnesi_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(49, 58);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 5;
            this.lblIme.Text = "Ime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(49, 97);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 6;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblGodiste
            // 
            this.lblGodiste.AutoSize = true;
            this.lblGodiste.Location = new System.Drawing.Point(49, 135);
            this.lblGodiste.Name = "lblGodiste";
            this.lblGodiste.Size = new System.Drawing.Size(43, 13);
            this.lblGodiste.TabIndex = 7;
            this.lblGodiste.Text = "Godiste";
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Location = new System.Drawing.Point(49, 174);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(29, 13);
            this.lblPol.TabIndex = 8;
            this.lblPol.Text = "Zanr";
            // 
            // UCDodajGlumca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPol);
            this.Controls.Add(this.lblGodiste);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.btnPodnesi);
            this.Controls.Add(this.cmbBoxPol);
            this.Controls.Add(this.txtGodiste);
            this.Controls.Add(this.txtBoxPrezime);
            this.Controls.Add(this.txtIme);
            this.Name = "UCDodajGlumca";
            this.Size = new System.Drawing.Size(408, 342);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.TextBox txtGodiste;
        private System.Windows.Forms.ComboBox cmbBoxPol;
        private System.Windows.Forms.Button btnPodnesi;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblGodiste;
        private System.Windows.Forms.Label lblPol;

        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtGodiste { get => txtGodiste; set => txtGodiste = value; }
        public ComboBox CmbBoxPol { get => cmbBoxPol; set => cmbBoxPol = value; }
        public Button BtnPodnesi { get => btnPodnesi; set => btnPodnesi = value; }
        public Label LblIme { get => lblIme; set => lblIme = value; }
        public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
        public Label LblGodiste { get => lblGodiste; set => lblGodiste = value; }
        public Label LblPol { get => lblPol; set => lblPol = value; }
        public TextBox TxtBoxPrezime { get => txtBoxPrezime; set => txtBoxPrezime = value; }
    }
}
