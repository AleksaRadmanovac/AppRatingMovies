using Domen;
using Domen.Communication;
using Domen.Exceptions;
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
    public class OcenaGlumcaGUIController
    {
        public OcenaGlumca OcenaGlumca { get; set; }
        public UCOcenaFilma of;
        bool p = false;
        public OcenaGlumcaGUIController(UCOcenaGlumca ocenaGlumca, Glumac glumac)
        {
            OcenaGlumca = new OcenaGlumca();
            OcenaGlumca.Glumac = glumac;
            if (KorisnikCoordinator.Instance.Korisnik != null)
            {
                OcenaGlumca.Korisnik = KorisnikCoordinator.Instance.Korisnik;

                try
                {
                    try
                    {
                        OcenaGlumca = Communication.Instance.VratiOcenuGlumca(OcenaGlumca);
                    }
                    catch (IOException)
                    {
                        MainCoordinator.Instance.ServerskaGreska();
                    }
                    
                    p = true;
                }
                catch (MissingOcenaException)
                {
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            try
            {
                OcenaGlumca.Glumac = Communication.Instance.VratiSveOceneZaGlumca(OcenaGlumca.Glumac);
            }
            catch (IOException)
            {
                MainCoordinator.Instance.ServerskaGreska();
            }
            
            double prosecnaOcena = 0;
            int brojac = 0;
            foreach (OcenaGlumca oG in OcenaGlumca.Glumac.Ocene)
            {
                brojac++;
                if (oG.Ocena != 0) prosecnaOcena += oG.Ocena;
            }
            if (prosecnaOcena == 0) ocenaGlumca.LblProsecnaOcena.Text += "Nema ocena za glumca";
            else ocenaGlumca.LblProsecnaOcena.Text += (prosecnaOcena / brojac).ToString();
            List<Film> filmovi = Communication.Instance.PronadjiFilmovePoGlumcu(glumac.Id);
            try
            {
                filmovi = Communication.Instance.PronadjiFilmovePoGlumcu(glumac.Id);
            }
            catch (IOException)
            {
                MainCoordinator.Instance.ServerskaGreska();
            }
            foreach (Film film in filmovi)
            { 
                ocenaGlumca.ListBoxFilmovi.Items.Add(film);
            }
            ocenaGlumca.LblIme.Text = "Ime: " + glumac.Ime;
            ocenaGlumca.LblPrezime.Text = "Prezime: " + glumac.Prezime;
            ocenaGlumca.LblGodiste.Text = "Godiste: " + glumac.Godiste;
            ocenaGlumca.LblPol.Text = "Pol: " + glumac.Pol;
            if (KorisnikCoordinator.Instance.Korisnik == null)
            {
                ocenaGlumca.GrpBox1.Visible = false;
                ocenaGlumca.TxtGlumacKomentar.Visible = false;
                ocenaGlumca.BtnOceni.Visible = false;
               
            }
        }

        public OcenaGlumcaGUIController(UCOcenaGlumca ocenaGlumca, UCOcenaFilma ocenaFilma, Glumac glumac) : this(ocenaGlumca, glumac)
        {
            of = ocenaFilma;
            ocenaGlumca.LblNazad.Visible = true;
        }

        public void PostaviPostojecuOcenu(UCOcenaGlumca ocenaGlumca)
        {
            if (p)
            {                
                ocenaGlumca.TxtGlumacKomentar.Text = OcenaGlumca.Komentar;
                switch (OcenaGlumca.Ocena)
                {
                    case 1:
                        ocenaGlumca.RadioButton1.Checked = true;
                        break;
                    case 2:
                        ocenaGlumca.RadioButton2.Checked = true;
                        break;
                    case 3:
                        ocenaGlumca.RadioButton3.Checked = true;
                        break;
                    case 4:
                        ocenaGlumca.RadioButton4.Checked = true;
                        break;
                    case 5:
                        ocenaGlumca.RadioButton5.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }

        public void OceniGlumca(int o)
        {
            OcenaGlumca.Ocena = o;
        }

        public void KrajOcenjivanja(UCOcenaGlumca ocenaGlumca)
        {
            if (OcenaGlumca.Ocena == 0)
            {
                MessageBox.Show("Morate oceniti film");
                return;
            }
            OcenaGlumca.Komentar = ocenaGlumca.TxtGlumacKomentar.Text;
            try
            {
                if (p)
                {
                    try
                    {
                        Communication.Instance.PromeniOcenuGlumca(OcenaGlumca);
                    }
                    catch (IOException)
                    {
                        MainCoordinator.Instance.ServerskaGreska();
                    }
                }
                else
                {
                    try
                    {
                        Communication.Instance.SacuvajOcenuGlumca(OcenaGlumca);
                    }
                    catch (IOException)
                    {
                        MainCoordinator.Instance.ServerskaGreska();
                    }
                } 

                MessageBox.Show("Uspesno ocenjen " + OcenaGlumca.Glumac.Ime + " " + OcenaGlumca.Glumac.Prezime);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (of == null)
                    KorisnikCoordinator.Instance.ShowKorisnikPocetna();
                else Nazad();
            }
        }

        public void PrikaziFilm(UCOcenaGlumca ocenaGlumca)
        {
            Film film = (Film)ocenaGlumca.ListBoxFilmovi.SelectedItem;
            KorisnikCoordinator.Instance.ShowOcenaFilma(ocenaGlumca, film);
        }

        public void Nazad()
        {
            KorisnikCoordinator.Instance.ShowOcenaFilma(of);
        }

    }
}
