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
    public partial class UCAdministratorPocetna : UserControl
    {
        AdministratorPocetnaGUIController controller;
        public UCAdministratorPocetna()
        {
            InitializeComponent();
            controller = new AdministratorPocetnaGUIController(this);
        }

        private void dgvZahteviFilm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.IzaberiZahtevZaFilm(this);
        }

        private void dgvZahteviGlumac_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.IzaberiZahtevZaGlumca(this);
        }
    }
}
