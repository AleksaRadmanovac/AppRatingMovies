using Domen;
using Forme.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.Forme
{
    public partial class FormKorisnik : Form
    {
        public FormKorisnik()
        {
            InitializeComponent();
            if(KorisnikCoordinator.Instance.Korisnik != null) lblKorisnik.Text = KorisnikCoordinator.Instance.Korisnik.Username;
            this.ChangeUserControl(new UCKorisnikPocetna());
        }

        public void ChangeUserControl(Control control)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            pnlMain.AutoSize = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KorisnikCoordinator.Instance.ShowKorisnikPocetna();
        }

        private void dodajFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KorisnikCoordinator.Instance.ShowDodajFilm();
        }

        private void dodajGlumcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KorisnikCoordinator.Instance.ShowDodajGlumca();
        }
    }
}
