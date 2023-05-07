using Domen;
using Forme.UserControls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Forme.GUIControllers
{
    public class DodajFilmGUIController
    {
        public ZahtevZaFilm zahtevZaFilm;
        private Glumac glumac;

        public DodajFilmGUIController(UCDodajFilm dodajFilm)
        {
            dodajFilm.CmbBoxZanr.DataSource = Enum.GetValues(typeof(Zanr));
            try
            {
                dodajFilm.DgvPretragaFilmova.DataSource = Communication.Instance.UcitajListuFilmova();
            } catch(IOException ex) 
            {
                MainCoordinator.Instance.ServerskaGreska();
            }
            zahtevZaFilm = new ZahtevZaFilm();
            zahtevZaFilm.Film = new Film();
            zahtevZaFilm.Uloge = new List<Uloga>();
        }
        public void UkljuciDodavanjeUloge(UCDodajFilm dodajFilm)
        {
            dodajFilm.TxtBoxPretraga.Enabled = true;
            dodajFilm.TxtBoxImeUloge.Enabled = true;
            dodajFilm.BtnDodajUlogu.Enabled = true;
            dodajFilm.BtnPretrazi.Enabled = true;
            dodajFilm.CmbBoxZanr.Enabled = true;
            dodajFilm.DgvGlumci.Enabled = true;
            dodajFilm.BtnKraj.Enabled = true;
            dodajFilm.ChkBoxJeGlavna.Enabled = true;
            dodajFilm.LblGlumac.Enabled = true;
            dodajFilm.LblImeUloge.Enabled = true;
            dodajFilm.LblPretrazi.Enabled = true;
            try
            {
                dodajFilm.DgvGlumci.DataSource = Communication.Instance.UcitajListuGlumaca();
            }
            catch (IOException ex)
            {
                MainCoordinator.Instance.ServerskaGreska();
            }
            
            foreach (DataGridViewColumn kolona in dodajFilm.DgvGlumci.Columns)
            {
                kolona.Visible = false;
            }
            dodajFilm.DgvGlumci.Columns["Ime"].Visible = true;
            dodajFilm.DgvGlumci.Columns["Prezime"].Visible = true;
            dodajFilm.DgvGlumci.Columns["Godiste"].Visible = true;
            dodajFilm.DgvGlumci.Columns["Pol"].Visible = true;
        }

        /*   public bool DodajFilm(UCDodajFilm dodajFilm)
           {
               try
               {
                   Film film = new Film();
                   film.Naziv = dodajFilm.TxtBoxNaziv.Text;
                   film.Zanr = (Zanr)dodajFilm.CmbBoxZanr.SelectedValue;
                   zahtevZaFilm = new ZahtevZaFilm();
                   zahtevZaFilm.Uloge = new List<Uloga>();
                   zahtevZaFilm.Film = film;

                   return true;
               }
               catch (Exception ex)
               {
                   MessageBox.Show("Doslo je do greske pri podnosenju zahteva");
                   Debug.WriteLine(ex.Message);
                   return false;
               }
           }*/

        public void DodajFilm(UCDodajFilm dodajFilm)
        {



                

        }

        public void OdabirGlumca(UCDodajFilm dodajFilm)
        {
            try
            {
                glumac = (Glumac)dodajFilm.DgvGlumci.SelectedRows[0].DataBoundItem;
                dodajFilm.TxtBoxGlumac.Text = glumac.Ime + " " + glumac.Prezime;
            }
            catch (Exception) { MessageBox.Show("Došlo je do greške"); }
        }

        public void DodajUlogu(UCDodajFilm dodajFilm)
        {
            if (glumac == null)
            { MessageBox.Show("Odaberite glumca za ulogu"); return; }
            if (dodajFilm.TxtBoxImeUloge.Text == null || dodajFilm.TxtBoxImeUloge.Text.Length == 0)
            { MessageBox.Show("Unesite ime uloge"); return; }
            Uloga uloga = new Uloga();
            uloga.Film = zahtevZaFilm.Film;
            uloga.Glumac = glumac;
            uloga.Ime = dodajFilm.TxtBoxImeUloge.Text;
            uloga.JeGlavna = dodajFilm.ChkBoxJeGlavna.Checked;
            zahtevZaFilm.Uloge.Add(uloga);
            //Communication.Instance.DodajUlogu(uloga);
            //MessageBox.Show("Uspesno dodata uloga za film " + trenutniFilm.Naziv);
            DodajUloguReset(dodajFilm);
            
        }

        public void DodajUloguReset(UCDodajFilm dodajFilm)
        {
            dodajFilm.TxtBoxGlumac.Text = null;
            dodajFilm.TxtBoxImeUloge.Text = null;
            dodajFilm.ChkBoxJeGlavna.Checked = false; 
            try
            {
                dodajFilm.DgvGlumci.DataSource = Communication.Instance.UcitajListuGlumaca();
            }
            catch (IOException ex)
            {
                MainCoordinator.Instance.ServerskaGreska();
            }
            
        }

        public void Pretrazi(UCDodajFilm dodajFilm)
        {
            List<Glumac> listaGlumaca = Communication.Instance.PretraziGlumce(dodajFilm.TxtBoxPretraga.Text);
            try
            {
                listaGlumaca = Communication.Instance.PretraziGlumce(dodajFilm.TxtBoxPretraga.Text);
            }
            catch (IOException ex)
            {
                MainCoordinator.Instance.ServerskaGreska();
            }
            
            dodajFilm.DgvGlumci.DataSource = listaGlumaca;
        }

        public void PretraziFilmove(UCDodajFilm dodajFilm)
        {
            List<Film> listaFilmova = Communication.Instance.PretraziFilmove(dodajFilm.TxtBoxPretraziFilmove.Text);
            try
            {
                listaFilmova = Communication.Instance.PretraziFilmove(dodajFilm.TxtBoxPretraziFilmove.Text);
            }
            catch (IOException ex)
            {
                MainCoordinator.Instance.ServerskaGreska();
            }
            dodajFilm.DgvPretragaFilmova.DataSource = listaFilmova;
        }

        public void OdabirFilma(UCDodajFilm dodajFilm)
        {
            try
            {
                Film film = (Film)dodajFilm.DgvPretragaFilmova.SelectedRows[0].DataBoundItem;
                dodajFilm.TxtBoxNaziv.Text = film.Naziv;
                dodajFilm.CmbBoxZanr.SelectedItem = film.Zanr;
            }
            catch (Exception) { }
        }

        public void Kraj(UCDodajFilm dodajFilm)
        {
            zahtevZaFilm.Film.Naziv = dodajFilm.TxtBoxNaziv.Text;
            zahtevZaFilm.Film.Zanr = (Zanr)dodajFilm.CmbBoxZanr.SelectedValue;
            try
            {
                Communication.Instance.PodnesiZahtevZaFilm(zahtevZaFilm);
            }
            catch (IOException)
            {
                MainCoordinator.Instance.ServerskaGreska();
            }
            
            MessageBox.Show("Uspesno podnet zahtev");
            KorisnikCoordinator.Instance.ShowKorisnikPocetna();
        }

        public void DodajGlumca(UCDodajFilm dodajFilm)
        {
            KorisnikCoordinator.Instance.ShowDodajGlumca(dodajFilm);
        }

    }
}
