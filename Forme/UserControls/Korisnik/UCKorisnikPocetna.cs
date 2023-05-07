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
    public partial class UCKorisnikPocetna : UserControl
    {
        private KorisnikPocetnaGUIController controller;
        public UCKorisnikPocetna()
        {
            InitializeComponent();
            controller = new KorisnikPocetnaGUIController(this);
        }

        private void btnPretraziFilmove_Click(object sender, EventArgs e)
        {
            controller.PretraziFilmove(this);
        }

        private void btnPretraziGlumce_Click(object sender, EventArgs e)
        {
            controller.PretraziGlumce(this);
        }

        private void dgvFilmovi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.IzaberiFilm(this);
        }

        private void dgvGlumci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.IzaberiGlumca(this);
        }

        private void dgvFilmovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
