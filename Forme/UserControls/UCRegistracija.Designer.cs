using System.Windows.Forms;

namespace Forme.UserControls
{
    partial class UCRegistracija
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblPol = new System.Windows.Forms.Label();
            this.cmbBoxPol = new System.Windows.Forms.ComboBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblError2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtUsername.Location = new System.Drawing.Point(130, 83);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(133, 67);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(133, 106);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtPassword.Location = new System.Drawing.Point(130, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(133, 145);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPassword.TabIndex = 6;
            this.lblConfirmPassword.Text = "Confirm Password";
            this.lblConfirmPassword.Click += new System.EventHandler(this.lblConfirmPassword_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtConfirmPassword.Location = new System.Drawing.Point(130, 161);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnRegister.Location = new System.Drawing.Point(130, 228);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 35);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Registruj se";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Location = new System.Drawing.Point(133, 184);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(22, 13);
            this.lblPol.TabIndex = 11;
            this.lblPol.Text = "Pol";
            this.lblPol.Click += new System.EventHandler(this.lblPol_Click);
            // 
            // cmbBoxPol
            // 
            this.cmbBoxPol.BackColor = System.Drawing.Color.NavajoWhite;
            this.cmbBoxPol.FormattingEnabled = true;
            this.cmbBoxPol.Location = new System.Drawing.Point(130, 201);
            this.cmbBoxPol.Name = "cmbBoxPol";
            this.cmbBoxPol.Size = new System.Drawing.Size(100, 21);
            this.cmbBoxPol.TabIndex = 12;
            this.cmbBoxPol.SelectedIndexChanged += new System.EventHandler(this.cmbBoxPol_SelectedIndexChanged);
            this.cmbBoxPol.TextChanged += new System.EventHandler(this.cmbBoxPol_TextChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLogin.Location = new System.Drawing.Point(4, 4);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(85, 13);
            this.lblLogin.TabIndex = 13;
            this.lblLogin.Text = "Nazad na Log in";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(120, 266);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(35, 13);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "label1";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError2.Location = new System.Drawing.Point(120, 266);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(35, 13);
            this.lblError2.TabIndex = 15;
            this.lblError2.Text = "label1";
            this.lblError2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError2.Visible = false;
            // 
            // UCRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblError2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.cmbBoxPol);
            this.Controls.Add(this.lblPol);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Name = "UCRegistracija";
            this.Size = new System.Drawing.Size(353, 327);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.ComboBox cmbBoxPol;
        private System.Windows.Forms.Label lblLogin;
        private Label lblError;
        private Label lblError2;

        public TextBox TxtUsername { get => txtUsername; set => txtUsername = value; }
        public Label LblUsername { get => lblUsername; set => lblUsername = value; }
        public Label LblPassword { get => lblPassword; set => lblPassword = value; }
        public TextBox TxtPassword { get => txtPassword; set => txtPassword = value; }
        public Label LblConfirmPassword { get => lblConfirmPassword; set => lblConfirmPassword = value; }
        public TextBox TxtConfirmPassword { get => txtConfirmPassword; set => txtConfirmPassword = value; }
        public Button BtnRegister { get => btnRegister; set => btnRegister = value; }
        public Label LblPol { get => lblPol; set => lblPol = value; }
        public ComboBox CmbBoxPol { get => cmbBoxPol; set => cmbBoxPol = value; }
        public Label LblLogin { get => lblLogin; set => lblLogin = value; }
        public Label LblError { get => lblError; set => lblError = value; }
        public Label LblError2 { get => lblError2; set => lblError2 = value; }
    }
}
