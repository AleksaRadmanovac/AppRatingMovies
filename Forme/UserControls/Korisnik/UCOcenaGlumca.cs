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
    public partial class UCOcenaGlumca : UserControl
    {
        private OcenaGlumcaGUIController controller;

        public UCOcenaGlumca(Glumac glumac)
        {
            InitializeComponent();
            controller = new OcenaGlumcaGUIController(this, glumac);
            controller.PostaviPostojecuOcenu(this);
        }

        public UCOcenaGlumca(UCOcenaFilma ocenaFilma, Glumac glumac)
        {
            InitializeComponent();
            controller = new OcenaGlumcaGUIController(this,ocenaFilma, glumac);
            controller.PostaviPostojecuOcenu(this);
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            controller.OceniGlumca(1);
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            controller.OceniGlumca(2);
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            controller.OceniGlumca(3);
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            controller.OceniGlumca(4);
        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            controller.OceniGlumca(5);
        }

        private void btnOceni_Click_1(object sender, EventArgs e)
        {
            controller.KrajOcenjivanja(this);
        }

        private void listBoxFilmovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFilmovi.SelectedItems.Count > 0)
                controller.PrikaziFilm(this);
        }

        private void lblNazad_Click(object sender, EventArgs e)
        {
            controller.Nazad();
        }

    }
}
