using Domen;
using Forme.UserControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.GUIControllers
{
    public class KorisnikPocetnaGUIController
    {
        List<Film> filmList;
        List<Glumac> glumacList;
        public KorisnikPocetnaGUIController(UCKorisnikPocetna korisnikPocetna)
        {
            try
            {
                korisnikPocetna.DgvFilmovi.DataSource = Communication.Instance.UcitajListuFilmova();
            }
            catch (IOException)
            {
                MainCoordinator.Instance.ServerskaGreska();
            }
            foreach (DataGridViewColumn kolona in korisnikPocetna.DgvFilmovi.Columns)
            {
                kolona.Width = 158;
                kolona.Visible = false;
            }
            korisnikPocetna.DgvFilmovi.Columns["Naziv"].Visible = true;
            korisnikPocetna.DgvFilmovi.Columns["Zanr"].Visible = true;
            try
            {
                korisnikPocetna.DgvGlumci.DataSource = Communication.Instance.UcitajListuGlumaca();
            }
            catch (IOException)
            {
                MainCoordinator.Instance.ServerskaGreska();
            }
            
            foreach (DataGridViewColumn kolona in korisnikPocetna.DgvGlumci.Columns)
            {
                kolona.Width = 79;
                kolona.Visible = false;
            }
            korisnikPocetna.DgvGlumci.Columns["Ime"].Visible = true;
            korisnikPocetna.DgvGlumci.Columns["Prezime"].Visible = true;
            korisnikPocetna.DgvGlumci.Columns["Godiste"].Visible = true;
            korisnikPocetna.DgvGlumci.Columns["Pol"].Visible = true;
        }
        public void PretraziFilmove(UCKorisnikPocetna korisnikPocetna)
        {
            try
            {
                filmList = Communication.Instance.PretraziFilmove(korisnikPocetna.TxtBoxPretrazivanjeFilmova.Text);
            }
            catch (IOException)
            {
                MainCoordinator.Instance.ServerskaGreska();
            }
            
            korisnikPocetna.DgvFilmovi.DataSource = filmList;
        }
        public void PretraziGlumce(UCKorisnikPocetna korisnikPocetna)
        {
            try
            {
                glumacList = Communication.Instance.PretraziGlumce(korisnikPocetna.TxtBoxPretrazivanjeGlumaca.Text);
            }
            catch (IOException)
            {
                MainCoordinator.Instance.ServerskaGreska();
            }
            
            korisnikPocetna.DgvGlumci.DataSource = glumacList;
        
        }

        public void IzaberiFilm(UCKorisnikPocetna korisnikPocetna)
        {
            try
            {
                Film film = (Film)korisnikPocetna.DgvFilmovi.SelectedRows[0].DataBoundItem;
                KorisnikCoordinator.Instance.ShowOcenaFilma(film);
            }
            catch (Exception) { }
        }

        public void IzaberiGlumca(UCKorisnikPocetna korisnikPocetna)
        {
            try
            {
                Glumac glumac = (Glumac)korisnikPocetna.DgvGlumci.SelectedRows[0].DataBoundItem;
                KorisnikCoordinator.Instance.ShowOcenaGlumca(glumac);
            }
            catch (Exception) { }

        }





    }
}
