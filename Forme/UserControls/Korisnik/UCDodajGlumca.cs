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
    public partial class UCDodajGlumca : UserControl
    {
        private DodajGlumcaGUIController controller;
        public UCDodajGlumca()
        {
            InitializeComponent();
            controller = new DodajGlumcaGUIController(this);
        }

        public UCDodajGlumca(UCDodajFilm dodajFilm)
        {
            InitializeComponent();
            controller = new DodajGlumcaGUIController(this, dodajFilm);
        }
        private void btnPodnesi_Click(object sender, EventArgs e)
        {
            controller.PodnesiZahtev(this);
        }

        private void txtGodiste_TextChanged(object sender, EventArgs e)
        {
            if (!char.IsDigit(txtGodiste.Text[txtGodiste.Text.Length - 1]))
            {
                MessageBox.Show("Mozete unositi samo brojeve");
                txtGodiste.Text.Remove(txtGodiste.Text.Length - 1);
            }
        }
    }
}
