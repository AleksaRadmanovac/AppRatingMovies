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
    public partial class UCLogin : UserControl
    {
        private LoginGUIController controller;
        public UCLogin()
        {
            InitializeComponent();
            controller = new LoginGUIController();
        }

        private void btnKorisnik_Click(object sender, EventArgs e)
        {
            controller.KorisnikLoginOpcija(this);
        }

        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            controller.AdministratorLoginOpcija(this);
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            controller.Prijava(this);
        }

        private void lblRegistracija_Click(object sender, EventArgs e)
        {
            controller.Registracija(this);
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {
            controller.SklanjanjeErrora(this);
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            controller.SklanjanjeErrora(this);
        }
    }
}
