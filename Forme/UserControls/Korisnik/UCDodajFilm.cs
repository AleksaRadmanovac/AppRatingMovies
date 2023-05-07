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
    public partial class UCDodajFilm : UserControl
    {
        private DodajFilmGUIController controller;
        public UCDodajFilm()
        {
            InitializeComponent();
            controller = new DodajFilmGUIController(this);
            controller.UkljuciDodavanjeUloge(this);
        }

        private void dgvGlumci_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgvGlumci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.OdabirGlumca(this);

        }

        private void dgvGlumci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnDodajUlogu_Click(object sender, EventArgs e)
        {
            controller.DodajUlogu(this);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            controller.Pretrazi(this);
        }

        private void btnKraj_Click(object sender, EventArgs e)
        {
            controller.Kraj(this);
        }

        private void btnPretraziFilmove_Click(object sender, EventArgs e)
        {
            controller.PretraziFilmove(this);
        }

        private void dgvPretragaFilmova_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvPretragaFilmova_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.OdabirFilma(this);
        }

        private void lblDodajGlumca_Click(object sender, EventArgs e)
        {
            controller.DodajGlumca(this);
        }
    }
}
