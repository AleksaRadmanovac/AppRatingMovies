using System.Windows.Forms;

namespace Forme.UserControls
{
    partial class UCLogin
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
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnKorisnik = new System.Windows.Forms.Button();
            this.btnAdministrator = new System.Windows.Forms.Button();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRegistracija = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxUsername.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtBoxUsername.Location = new System.Drawing.Point(193, 93);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUsername.TabIndex = 0;
            this.txtBoxUsername.TextChanged += new System.EventHandler(this.txtBoxUsername_TextChanged);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxPassword.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtBoxPassword.Location = new System.Drawing.Point(193, 145);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPassword.TabIndex = 1;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            // 
            // btnKorisnik
            // 
            this.btnKorisnik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKorisnik.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnKorisnik.Enabled = false;
            this.btnKorisnik.Location = new System.Drawing.Point(76, 93);
            this.btnKorisnik.Name = "btnKorisnik";
            this.btnKorisnik.Size = new System.Drawing.Size(75, 23);
            this.btnKorisnik.TabIndex = 2;
            this.btnKorisnik.Text = "Korisnik";
            this.btnKorisnik.UseVisualStyleBackColor = false;
            this.btnKorisnik.Click += new System.EventHandler(this.btnKorisnik_Click);
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdministrator.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAdministrator.Location = new System.Drawing.Point(76, 145);
            this.btnAdministrator.Name = "btnAdministrator";
            this.btnAdministrator.Size = new System.Drawing.Size(75, 23);
            this.btnAdministrator.TabIndex = 3;
            this.btnAdministrator.Text = "Administrator";
            this.btnAdministrator.UseVisualStyleBackColor = false;
            this.btnAdministrator.Click += new System.EventHandler(this.btnAdministrator_Click);
            // 
            // btnPrijava
            // 
            this.btnPrijava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrijava.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnPrijava.Location = new System.Drawing.Point(132, 199);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(100, 51);
            this.btnPrijava.TabIndex = 4;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(193, 74);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(190, 129);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRegistracija.Location = new System.Drawing.Point(190, 168);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(107, 13);
            this.lblRegistracija.TabIndex = 7;
            this.lblRegistracija.Text = "Registracija korisnika";
            this.lblRegistracija.Click += new System.EventHandler(this.lblRegistracija_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(151, 116);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(186, 13);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Username i password se ne poklapaju";
            this.lblError.Visible = false;
            // 
            // UCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblRegistracija);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.btnAdministrator);
            this.Controls.Add(this.btnKorisnik);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUsername);
            this.Name = "UCLogin";
            this.Size = new System.Drawing.Size(372, 343);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnKorisnik;
        private System.Windows.Forms.Button btnAdministrator;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private Label lblRegistracija;
        private Label lblError;

        public TextBox TxtBoxUsername { get => txtBoxUsername; set => txtBoxUsername = value; }
        public TextBox TxtBoxPassword { get => txtBoxPassword; set => txtBoxPassword = value; }
        public Button BtnKorisnik { get => btnKorisnik; set => btnKorisnik = value; }
        public Button BtnAdministrator { get => btnAdministrator; set => btnAdministrator = value; }
        public Button BtnPrijava { get => btnPrijava; set => btnPrijava = value; }
        public Label LblUsername { get => lblUsername; set => lblUsername = value; }
        public Label LblPassword { get => lblPassword; set => lblPassword = value; }
        public Label LblRegistracija { get => lblRegistracija; set => lblRegistracija = value; }
        public Label LblError { get => lblError; set => lblError = value; }
    }
}
