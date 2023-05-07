using System.Windows.Forms;

namespace Forme.UserControls.Admin
{
    partial class UCObradaZahtevaZaGlumca
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
            this.lblPitanje = new System.Windows.Forms.Label();
            this.lblProveri = new System.Windows.Forms.Label();
            this.btnOdobri = new System.Windows.Forms.Button();
            this.btnOdbij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(314, 96);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(30, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime: ";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(314, 125);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(50, 13);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime: ";
            // 
            // lblGodiste
            // 
            this.lblGodiste.AutoSize = true;
            this.lblGodiste.Location = new System.Drawing.Point(314, 154);
            this.lblGodiste.Name = "lblGodiste";
            this.lblGodiste.Size = new System.Drawing.Size(49, 13);
            this.lblGodiste.TabIndex = 2;
            this.lblGodiste.Text = "Godiste: ";
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Location = new System.Drawing.Point(314, 182);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(28, 13);
            this.lblPol.TabIndex = 3;
            this.lblPol.Text = "Pol: ";
            // 
            // lblPitanje
            // 
            this.lblPitanje.AutoSize = true;
            this.lblPitanje.Location = new System.Drawing.Point(314, 235);
            this.lblPitanje.Name = "lblPitanje";
            this.lblPitanje.Size = new System.Drawing.Size(145, 13);
            this.lblPitanje.TabIndex = 4;
            this.lblPitanje.Text = "Mozda je glumac vec u bazi?";
            // 
            // lblProveri
            // 
            this.lblProveri.AutoSize = true;
            this.lblProveri.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblProveri.Location = new System.Drawing.Point(410, 248);
            this.lblProveri.Name = "lblProveri";
            this.lblProveri.Size = new System.Drawing.Size(49, 13);
            this.lblProveri.TabIndex = 5;
            this.lblProveri.Text = "Proveri...";
            this.lblProveri.Click += new System.EventHandler(this.lblProveri_Click);
            // 
            // btnOdobri
            // 
            this.btnOdobri.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnOdobri.Location = new System.Drawing.Point(276, 290);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(97, 49);
            this.btnOdobri.TabIndex = 6;
            this.btnOdobri.Text = "Odobri unos glumca";
            this.btnOdobri.UseVisualStyleBackColor = false;
            this.btnOdobri.Click += new System.EventHandler(this.btnOdobri_Click);
            // 
            // btnOdbij
            // 
            this.btnOdbij.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnOdbij.Location = new System.Drawing.Point(398, 290);
            this.btnOdbij.Name = "btnOdbij";
            this.btnOdbij.Size = new System.Drawing.Size(97, 49);
            this.btnOdbij.TabIndex = 7;
            this.btnOdbij.Text = "Odbij";
            this.btnOdbij.UseVisualStyleBackColor = false;
            this.btnOdbij.Click += new System.EventHandler(this.btnOdbij_Click);
            // 
            // UCObradaZahtevaZaGlumca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOdbij);
            this.Controls.Add(this.btnOdobri);
            this.Controls.Add(this.lblProveri);
            this.Controls.Add(this.lblPitanje);
            this.Controls.Add(this.lblPol);
            this.Controls.Add(this.lblGodiste);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Name = "UCObradaZahtevaZaGlumca";
            this.Size = new System.Drawing.Size(784, 427);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblGodiste;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.Label lblPitanje;
        private System.Windows.Forms.Label lblProveri;
        private System.Windows.Forms.Button btnOdobri;
        private System.Windows.Forms.Button btnOdbij;

        public Label LblIme { get => lblIme; set => lblIme = value; }
        public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
        public Label LblGodiste { get => lblGodiste; set => lblGodiste = value; }
        public Label LblPol { get => lblPol; set => lblPol = value; }
        public Label LblPitanje { get => lblPitanje; set => lblPitanje = value; }
        public Label LblProveri { get => lblProveri; set => lblProveri = value; }
        public Button BtnOdobri { get => btnOdobri; set => btnOdobri = value; }
        public Button BtnOdbij { get => btnOdbij; set => btnOdbij = value; }
    }
}
