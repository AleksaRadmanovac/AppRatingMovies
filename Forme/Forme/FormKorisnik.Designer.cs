using System.Windows.Forms;

namespace Forme.Forme
{
    partial class FormKorisnik
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajGlumcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(17, 39);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1033, 500);
            this.pnlMain.TabIndex = 0;
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.BackColor = System.Drawing.Color.SandyBrown;
            this.lblKorisnik.Location = new System.Drawing.Point(932, 20);
            this.lblKorisnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(0, 16);
            this.lblKorisnik.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.dodajFilmToolStripMenuItem,
            this.dodajGlumcaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(75, 26);
            this.toolStripMenuItem1.Text = "Pocetna";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // dodajFilmToolStripMenuItem
            // 
            this.dodajFilmToolStripMenuItem.Name = "dodajFilmToolStripMenuItem";
            this.dodajFilmToolStripMenuItem.Size = new System.Drawing.Size(96, 26);
            this.dodajFilmToolStripMenuItem.Text = "Dodaj Film";
            this.dodajFilmToolStripMenuItem.Click += new System.EventHandler(this.dodajFilmToolStripMenuItem_Click);
            // 
            // dodajGlumcaToolStripMenuItem
            // 
            this.dodajGlumcaToolStripMenuItem.Name = "dodajGlumcaToolStripMenuItem";
            this.dodajGlumcaToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.dodajGlumcaToolStripMenuItem.Text = "Dodaj Glumca";
            this.dodajGlumcaToolStripMenuItem.Click += new System.EventHandler(this.dodajGlumcaToolStripMenuItem_Click);
            // 
            // FormKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormKorisnik";
            this.Text = "KorisnikForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajGlumcaToolStripMenuItem;

        public ToolStripMenuItem DodajFilmToolStripMenuItem { get => dodajFilmToolStripMenuItem; set => dodajFilmToolStripMenuItem = value; }
        public ToolStripMenuItem DodajGlumcaToolStripMenuItem { get => dodajGlumcaToolStripMenuItem; set => dodajGlumcaToolStripMenuItem = value; }
    }
}