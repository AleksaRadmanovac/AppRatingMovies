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
    public partial class UCObradaZahtevaZaFilm : UserControl
    {
        public ObradaZahtevaZaFilmGUIController controller;

        public UCObradaZahtevaZaFilm(ZahtevZaFilm zahtevZaFilm)
        {
            InitializeComponent();
            controller = new ObradaZahtevaZaFilmGUIController(this, zahtevZaFilm);
        }

        private void lblViseOGlumcu_Click(object sender, EventArgs e)
        {
            controller.ViseOGlumcu(this);
        }

        private void lblProveri_Click(object sender, EventArgs e)
        {
            controller.Pretrazi();
        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {
            controller.Odobri();
        }

        private void btnOdbij_Click(object sender, EventArgs e)
        {
            controller.Odbij();
        }

        private void btnDodajUlogePocetak_Click(object sender, EventArgs e)
        {
            controller.DodajUlogePrikazi(this);
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            controller.Pretraga(this);
        }

        private void lblViseOFilmu_Click(object sender, EventArgs e)
        {
            controller.ViseOFilmu(this);
        }

        private void btnDodajUlogeKraj_Click(object sender, EventArgs e)
        {
            controller.DodajUlogeKraj(this);
        }
    }
}
