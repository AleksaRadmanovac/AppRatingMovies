using Domen;
using Forme.UserControls;
using Forme.UserControls.Admin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.GUIControllers.Admin
{
    public class ObradaZahtevaZaFilmGUIController
    {
        public ZahtevZaFilm zahtevZaFilm;

        public ObradaZahtevaZaFilmGUIController(UCObradaZahtevaZaFilm obradaZahteva, ZahtevZaFilm z)
        {
            zahtevZaFilm = z;
            zahtevZaFilm.Film.Uloge = new List<Uloga>();
            foreach (Uloga uloga in z.Uloge)
            {
                zahtevZaFilm.Film.Uloge.Add(uloga);
            }
            zahtevZaFilm.Obradjen = true;
            zahtevZaFilm.Administrator = AdministratorCoordinator.Instance.Administrator; 
            obradaZahteva.LblNaziv.Text += z.Film.Naziv;
            obradaZahteva.LblZanr.Text += z.Film.Zanr.ToString();
            foreach (Uloga uloga in z.Uloge)
            {
                obradaZahteva.ListBoxUloge.Items.Add(uloga);
            }
        }

        public void ViseOGlumcu(UCObradaZahtevaZaFilm obradaZahteva)
        {
            if ((Uloga)obradaZahteva.ListBoxUloge.SelectedItem != null)
            {
                Glumac glumac = ((Uloga)obradaZahteva.ListBoxUloge.SelectedItem).Glumac;
                KorisnikCoordinator.Instance.ShowFrmKorisnik(null);
                KorisnikCoordinator.Instance.ShowOcenaGlumca(glumac);
            }
        }

        public void Pretrazi()
        {
            KorisnikCoordinator.Instance.ShowFrmKorisnik(null);
        }

        public void Odobri()
        {
            zahtevZaFilm.Odobren = true;
            zahtevZaFilm.Film.Prikazan = true; 
            try
            {
                AdministratorCoordinator.Instance.Administrator.BrojObradjenihZahteva++;
                try
                {
                    Communication.Instance.SacuvajOdluku(zahtevZaFilm);
                }
                catch (IOException)
                {
                    MainCoordinator.Instance.ServerskaGreska();
                }
                
                MessageBox.Show("Uspesno obradjen zahtev");
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                AdministratorCoordinator.Instance.ShowAdministratorPocetka();
            }
        }

        public void Odbij()
        {           
            try
            {
                AdministratorCoordinator.Instance.Administrator.BrojObradjenihZahteva++;
                try
                {
                    Communication.Instance.SacuvajOdluku(zahtevZaFilm);
                }
                catch (IOException)
                {
                    MainCoordinator.Instance.ServerskaGreska();
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                AdministratorCoordinator.Instance.ShowAdministratorPocetka();
            }
        }

        public void DodajUlogePrikazi(UCObradaZahtevaZaFilm obradaZahteva)
        {
            obradaZahteva.PnlDodajUloge.Visible = true;
            obradaZahteva.BtnDodajUlogeKraj.Visible = true;
            foreach (Uloga uloga in zahtevZaFilm.Uloge)
            {
                obradaZahteva.ChkListBoxUloge.Items.Add(uloga);
            }
            obradaZahteva.TxtBoxPretraga.Text = zahtevZaFilm.Film.Naziv;  
            try
            {
                obradaZahteva.DgvPretraga.DataSource = Communication.Instance.PretraziFilmove(zahtevZaFilm.Film.Naziv);
            }
            catch (IOException)
            {
                MainCoordinator.Instance.ServerskaGreska();
            }
            foreach (DataGridViewColumn kolona in obradaZahteva.DgvPretraga.Columns)
            {
                kolona.Visible = false;
            }
            obradaZahteva.DgvPretraga.Columns["Naziv"].Visible = true;
            obradaZahteva.DgvPretraga.Columns["Zanr"].Visible = true;
        }

        public void Pretraga(UCObradaZahtevaZaFilm obradaZahteva)
        {
            List<Film> filmovi = Communication.Instance.PretraziFilmove(obradaZahteva.TxtBoxPretraga.Text);
            try
            {
                filmovi = Communication.Instance.PretraziFilmove(obradaZahteva.TxtBoxPretraga.Text);
            }
            catch (IOException)
            {
                MainCoordinator.Instance.ServerskaGreska();
            }
            obradaZahteva.DgvPretraga.DataSource = filmovi;
            
        }

        public void ViseOFilmu(UCObradaZahtevaZaFilm obradaZahteva)
        {
            if (obradaZahteva.DgvPretraga.SelectedRows.Count > 0)
            {
                Film film = (Film)obradaZahteva.DgvPretraga.SelectedRows[0].DataBoundItem;
                KorisnikCoordinator.Instance.ShowFrmKorisnik(null);
                KorisnikCoordinator.Instance.ShowOcenaFilma(film);
            }
        }

        public void DodajUlogeKraj(UCObradaZahtevaZaFilm obradaZahteva)
        {
            zahtevZaFilm.Odobren = true;
            if (obradaZahteva.DgvPretraga.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Morate da odabere film u koji zelite da dodate uloge");
                return;
            }
            if (obradaZahteva.ChkListBoxUloge.CheckedItems.Count == 0)
            {
                MessageBox.Show("Morate obeleziti ulogu koju zelite da dodate");
                return;
            }
            List<Uloga> listaUloga = new List<Uloga>();
            for (int i = 0; i < obradaZahteva.ChkListBoxUloge.CheckedItems.Count; i++) 
            {
                
                //zahtevZaFilm.Uloge.Add(uloga);
                ((Uloga)obradaZahteva.ChkListBoxUloge.CheckedItems[i]).Film = (Film)obradaZahteva.DgvPretraga.SelectedRows[0].DataBoundItem;
                
            }

            //zahtevZaFilm.Film = null;
            try
            {
                AdministratorCoordinator.Instance.Administrator.BrojObradjenihZahteva++;
                try
                {
                    Communication.Instance.SacuvajOdluku(zahtevZaFilm, true);
                }
                catch (IOException)
                {
                    MainCoordinator.Instance.ServerskaGreska();
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally 
            {
                AdministratorCoordinator.Instance.ShowAdministratorPocetka();
            }
        }

    }
}
