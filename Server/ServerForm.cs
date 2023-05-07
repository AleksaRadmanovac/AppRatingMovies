using Domen;
using Domen.Exceptions;
using Microsoft.Win32;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerForm : Form
    {
        private Server server;
        public ServerForm()
        {
            InitializeComponent();
            server = new Server();
            server.Start();
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            server.Start();
            btnPokreni.Enabled = false;
            btnZaustavi.Enabled = true;
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            server.Close();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtBoxUsername.Text.Length < 1) 
            {
                lblError.Visible = true;
                txtBoxUsername.BorderStyle = BorderStyle.FixedSingle;
                txtBoxUsername.BackColor = Color.IndianRed;
                lblError.Text = "Morate uneti korisnicko ime";
                SklanjanjeErroraPassword();
                return;
            }
            if (txtBoxPassword.Text.Length < 4) 
            {
                lblError2.Visible = true;
                txtBoxPassword.BorderStyle = BorderStyle.FixedSingle;
                txtBoxPassword.BackColor = Color.IndianRed;
                txtBoxConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
                txtBoxConfirmPassword.BackColor = Color.IndianRed;
                lblError2.Text = "Password mora imati 4 ili vise karaktera";
                SklanjanjeErroraUsername();
                return;
            }
            if (txtBoxPassword.Text == txtBoxConfirmPassword.Text)
            {
                try
                {
                    Administrator administrator = new Administrator();
                    administrator.Username = txtBoxUsername.Text;
                    administrator.Password = txtBoxPassword.Text;
                    SORegistracijaAdministratora so = new SORegistracijaAdministratora();
                    so.Administrator = administrator;
                    so.Izvrsi();
                    MessageBox.Show("Uspesna registracija");
                    txtBoxUsername.Text = null;
                    txtBoxPassword.Text = null;
                    txtBoxConfirmPassword.Text = null;
                }
                catch (UsernamePostojiException) {
                    lblError.Visible = true;
                    txtBoxUsername.BorderStyle = BorderStyle.FixedSingle;
                    txtBoxUsername.BackColor = Color.IndianRed;
                    lblError.Text = "Korisnicko ime je zauzeto";
                    SklanjanjeErroraPassword();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                lblError2.Visible = true;
                txtBoxPassword.BorderStyle = BorderStyle.FixedSingle;
                txtBoxPassword.BackColor = Color.IndianRed;
                txtBoxConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
                txtBoxConfirmPassword.BackColor = Color.IndianRed;
                lblError2.Text = "Vase sifre se ne poklapaju";
                SklanjanjeErroraUsername();
            }
        }
        public void SklanjanjeErroraUsername()
        {
            txtBoxUsername.BackColor = Color.White;
            lblError.Visible = false;
        }
        public void SklanjanjeErroraPassword()
        {
            txtBoxPassword.BackColor = Color.White;
            txtBoxConfirmPassword.BackColor = Color.White;
            lblError2.Visible = false;
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {
            SklanjanjeErroraUsername();
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            SklanjanjeErroraPassword();
        }

        private void txtBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            SklanjanjeErroraPassword();
        }
    }
}
