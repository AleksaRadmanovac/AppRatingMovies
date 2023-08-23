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
    public partial class UCOcenaFilma : UserControl
    {
        private OcenaFilmaGUIController controller;
        public UCOcenaFilma(Film film)
        {
            InitializeComponent();
            controller = new OcenaFilmaGUIController(this, film);
            controller.PostaviPostojeceOcene(this);
        }

        public UCOcenaFilma(UCOcenaGlumca ocenaGlumca, Film film)
        {
            InitializeComponent();
            controller = new OcenaFilmaGUIController(this, ocenaGlumca, film);
            controller.PostaviPostojeceOcene(this);
        }

        private void listBoxUloge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUloge.SelectedItems.Count > 0)
                controller.OdaberiUlogu(this);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //controller.OceniUlogu(1);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
           // controller.OceniUlogu(2);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
           // controller.OceniUlogu(3);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
           // controller.OceniUlogu(4);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
           // controller.OceniUlogu(5);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            controller.OceniFilm(1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            controller.OceniFilm(2);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            controller.OceniFilm(3);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            controller.OceniFilm(4);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            controller.OceniFilm(5);
        }

        private void txtKomentarUloga_Leave(object sender, EventArgs e)
        {
            controller.OstaviKomentarUloga(this);
        }

        private void btnOceni_Click(object sender, EventArgs e)
        {
            controller.KrajOcenjivanja(this);
        }

        private void lblNazad_Click(object sender, EventArgs e)
        {
            controller.Nazad();
        }

        private void lblGlumac_Click(object sender, EventArgs e)
        {
            controller.PrikaziGlumca(this);
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            controller.OceniUlogu(1);
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            controller.OceniUlogu(2);
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            controller.OceniUlogu(3);
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            controller.OceniUlogu(4);
        }

        private void radioButton10_Click(object sender, EventArgs e)
        {
            controller.OceniUlogu(5);
        }

        private void btnStampaj_Click(object sender, EventArgs e)
        {
            controller.Odstampaj();
        }
    }
}
