using Domen;
using Forme.Forme;
using Forme.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forme
{
    public class KorisnikCoordinator
    {
        public Korisnik Korisnik { get; set; }
        private static KorisnikCoordinator instance;
        private FormKorisnik frmKorisnik;
        public static KorisnikCoordinator Instance
        {
            get
            {
                if (instance == null)
                    instance = new KorisnikCoordinator();
                return instance;
            }
        }

        private KorisnikCoordinator() { }
        public void ShowFrmKorisnik(Korisnik korisnik)
        {
            Korisnik = korisnik;
            frmKorisnik = new FormKorisnik();
            if (Korisnik == null)
            {
                frmKorisnik.DodajFilmToolStripMenuItem.Visible = false;
                frmKorisnik.DodajGlumcaToolStripMenuItem.Visible = false;
            }
            frmKorisnik.Show();
        }
        public void ShowKorisnikPocetna()
        {
            frmKorisnik.ChangeUserControl(new UCKorisnikPocetna());
        }

        public void ShowDodajFilm()
        {
            frmKorisnik.ChangeUserControl(new UCDodajFilm());
        }

        public void ShowDodajGlumca()
        {
            frmKorisnik.ChangeUserControl(new UCDodajGlumca());
        }
        public void ShowDodajGlumca(UCDodajFilm dodajFilm)
        {
            frmKorisnik.ChangeUserControl(new UCDodajGlumca(dodajFilm));
        }

        public void ShowOcenaFilma(Film film)
        {
            frmKorisnik.ChangeUserControl(new UCOcenaFilma(film));
        }

        public void ShowOcenaFilma(UCOcenaFilma ocenaFilma)
        {
            frmKorisnik.ChangeUserControl(ocenaFilma);
        }

        public void ShowOcenaFilma(UCOcenaGlumca ocenaGlumca, Film film)
        {
            frmKorisnik.ChangeUserControl(new UCOcenaFilma(ocenaGlumca, film));
        }

        public void ShowOcenaGlumca(Glumac glumac)
        {
            frmKorisnik.ChangeUserControl(new UCOcenaGlumca(glumac));
        }

        public void ShowOcenaGlumca(UCOcenaFilma ocenaFilma, Glumac glumac)
        {
            frmKorisnik.ChangeUserControl(new UCOcenaGlumca(ocenaFilma, glumac));
        }

        public void ShowOcenaGlumca(UCOcenaGlumca ocenaGlumca)
        {
            frmKorisnik.ChangeUserControl(ocenaGlumca);
        }


        public void ReturnToDodajGlumca(UCDodajFilm dodajFilm)
        {
            frmKorisnik.ChangeUserControl(dodajFilm);
        }
    }
}
