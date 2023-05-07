using Domen;
using Forme.GUIControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.UserControls
{
    public partial class UCRegistracija : UserControl
    {
        private RegistracijaGUIController controller;
        public UCRegistracija()
        {
            InitializeComponent();
            controller = new RegistracijaGUIController(this);
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            controller.NazadNaLogin();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            controller.Registracija(this);
        }

        private void cmbBoxPol_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPol_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            controller.SklanjanjeErroraUsername(this);
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            controller.SklanjanjeErroraPassword(this);
        }

        private void lblConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            controller.SklanjanjeErroraPassword(this);
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void cmbBoxPol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
