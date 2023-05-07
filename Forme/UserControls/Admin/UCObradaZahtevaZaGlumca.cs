using Domen;
using Forme.GUIControllers.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.UserControls.Admin
{
    public partial class UCObradaZahtevaZaGlumca : UserControl
    {
        ObradaZahtevaZaGlumcaGUIController controller;
        public UCObradaZahtevaZaGlumca(ZahtevZaGlumca zahtevZaGlumca)
        {
            InitializeComponent();
            controller = new ObradaZahtevaZaGlumcaGUIController(this, zahtevZaGlumca);
        }

        private void lblProveri_Click(object sender, EventArgs e)
        {
            controller.Proveri();
        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {
            controller.Odobri();
        }

        private void btnOdbij_Click(object sender, EventArgs e)
        {
            controller.Odbij();
        }
    }
}
