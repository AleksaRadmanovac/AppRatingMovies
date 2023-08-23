using Domen;
using Domen.Communication;
using Domen.Exceptions;
using Forme.UserControls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Forme.GUIControllers
{
    public class OcenaFilmaGUIController
    {
        public OcenaFilma ocenaFilm;
        public Film prikazaniFilm;
        public List<OcenaUloge> oceneUloga;
        public OcenaUloge trenutnaUloga;
        public List<OcenaUloge> listaOcenaUloga = new List<OcenaUloge>();
        public UCOcenaGlumca og;
        bool p = false;
        VratiOceneOdgovor odgovor = new VratiOceneOdgovor();

        public OcenaFilmaGUIController(UCOcenaFilma ocenaFilma, Film film)
        {
            ocenaFilm = new OcenaFilma();
            ocenaFilm.Korisnik = KorisnikCoordinator.Instance.Korisnik;
            ocenaFilm.Film = film;
            List<Uloga> listaUloga = new List<Uloga>();
            
            if (KorisnikCoordinator.Instance.Korisnik != null)
            {
                try
                {
                    
                    odgovor = Communication.Instance.VratiOceneFilma(ocenaFilm);

                    p = true;
                    
                }
                catch (IOException)
                {
                    MainCoordinator.Instance.ServerskaGreska();
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
                ocenaFilm.Film = Communication.Instance.VratiSveOceneZaFilm(ocenaFilm.Film);
                prikazaniFilm = ocenaFilm.Film;
            }
            catch (IOException)
            {
                MainCoordinator.Instance.ServerskaGreska();
            }
            listaUloga = film.Uloge;
            foreach (Uloga uloga in listaUloga)
            {
                ocenaFilma.ListBoxUloge.Items.Add(uloga);
                OcenaUloge ou = new OcenaUloge();
                ou.Korisnik = KorisnikCoordinator.Instance.Korisnik;
                ou.Uloga = uloga;
                listaOcenaUloga.Add(ou);
            }
            double prosecnaOcena = 0;
            int brojac = 0;
            foreach (OcenaFilma oF in ocenaFilm.Film.Ocene)
            {
                brojac++;
                if (oF.Ocena != 0) prosecnaOcena += oF.Ocena;
            }
            if(prosecnaOcena== 0) ocenaFilma.LblProsecnaOcena.Text += "Nema ocena za film";
            else ocenaFilma.LblProsecnaOcena.Text += (prosecnaOcena / brojac).ToString();
            if (ocenaFilm.Film.Uloge.Count != 0)
            {
                ocenaFilma.ListBoxOceneUloge.Visible = true;
                ocenaFilma.LblUlogaOcena1.Visible = true;
                foreach (Uloga u in ocenaFilm.Film.Uloge)
                {
                    double prOcenaUloge = 0;
                    int brojacU = 0;
                    foreach (OcenaUloge oU in u.Ocene)
                    {
                        brojacU++;
                        if (oU.Ocena != 0) prOcenaUloge += oU.Ocena;
                    }
                    if (u.Ocene.Count != 0)
                    {
                        prOcenaUloge = prOcenaUloge / brojacU;
                        if(prOcenaUloge != 0)
                        ocenaFilma.ListBoxOceneUloge.Items.Add(prOcenaUloge);
                        else ocenaFilma.ListBoxOceneUloge.Items.Add("/");
                    }
                    else ocenaFilma.ListBoxOceneUloge.Items.Add("/");
                    

                }
            }
            if (p)
            {
                if (KorisnikCoordinator.Instance.Korisnik != null) {
                    if (odgovor.OceneUloga.Count < listaUloga.Count)
                    {
                        List<Uloga> lU = new List<Uloga>();
                        List<Uloga> lU2 = new List<Uloga>();
                        foreach (OcenaUloge oU in odgovor.OceneUloga)
                        {
                            lU2.Add(oU.Uloga);
                        }
                        foreach (Uloga u in listaUloga)
                        {
                            if (lU2.Contains(u)) { }
                            else
                            {
                                lU.Add(u);

                            }
                        }
                        List<OcenaUloge> lOU = new List<OcenaUloge>();
                        foreach (Uloga u3 in lU)
                        {
                            OcenaUloge oU2 = new OcenaUloge();
                            oU2.Korisnik = KorisnikCoordinator.Instance.Korisnik;
                            oU2.Uloga = u3;
                            lOU.Add(oU2);
                        }
                        Communication.Instance.SacuvajOcene(null, lOU);
                    } 
                }
            }
            ocenaFilma.LblNaziv.Text = film.Naziv;
            ocenaFilma.LblZanr.Text += film.Zanr.ToString();
            
            if (ocenaFilma.ListBoxUloge.Items.Count < 1)
            {
                ocenaFilma.LblUloge.Text = "Nema dostupnih uloga za ovaj film";
                ocenaFilma.LblGlumac.Visible = false;
                ocenaFilma.ListBoxUloge.Visible = false;
            }
            if (KorisnikCoordinator.Instance.Korisnik == null)
            {
                ocenaFilma.GrpBox1.Visible = false;
                ocenaFilma.GrpBox2.Visible = false;
                ocenaFilma.TxtFilmKomentar.Visible = false;
                ocenaFilma.TxtKomentarUloga.Visible = false;
                ocenaFilma.LblGlumac.Location = new System.Drawing.Point(263, 308);
                ocenaFilma.LblGlumac.Enabled = true;
                ocenaFilma.BtnOceni.Visible = false;
            }
            
        }

        public OcenaFilmaGUIController(UCOcenaFilma ocenaFilma, UCOcenaGlumca ocenaGlumca, Film film) : this(ocenaFilma, film)
        {
            og = ocenaGlumca;
            ocenaFilma.LblNazad.Visible = true;
        }

        public void PostaviPostojeceOcene(UCOcenaFilma ocenaFilma)
        {
            if (p)
            {
                ocenaFilm = odgovor.OcenaFilma;
                for (int i = 0; i < listaOcenaUloga.Count; i++)
                {
                    foreach (OcenaUloge ou in odgovor.OceneUloga)
                    {
                        if (ou.Uloga.Glumac.Id == listaOcenaUloga[i].Uloga.Glumac.Id)
                        {
                            listaOcenaUloga[i].Ocena = ou.Ocena;
                            listaOcenaUloga[i].Komentar = ou.Komentar;
                        }
                    }
                }
                //oceneUloga = odgovor.OceneUloga;
                ocenaFilma.TxtFilmKomentar.Text = ocenaFilm.Komentar;
                switch (ocenaFilm.Ocena)
                {
                    case 1:
                        ocenaFilma.RadioButton1.Checked = true;
                        break;
                    case 2:
                        ocenaFilma.RadioButton2.Checked = true;
                        break;
                    case 3:
                        ocenaFilma.RadioButton3.Checked = true;
                        break;
                    case 4:
                        ocenaFilma.RadioButton4.Checked = true;
                        break;
                    case 5:
                        ocenaFilma.RadioButton5.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }

        public void OdaberiUlogu(UCOcenaFilma ocenaFilma)
        {
            //trenutnaUloga.Ocena = 0;
            ocenaFilma.GrpBox2.Enabled = true;
            ocenaFilma.TxtKomentarUloga.Enabled = true;
            ocenaFilma.ListBoxUloge.Visible = true;
            ocenaFilma.LblGlumac.Enabled = true;
            trenutnaUloga = new OcenaUloge();
            if(KorisnikCoordinator.Instance.Korisnik != null) trenutnaUloga.Korisnik = KorisnikCoordinator.Instance.Korisnik;
            trenutnaUloga.Uloga = (Uloga)ocenaFilma.ListBoxUloge.SelectedItem;
            ocenaFilma.GrpBox2.Text = ((Uloga)ocenaFilma.ListBoxUloge.SelectedItem).Ime;

            for (int i = 0; i < listaOcenaUloga.Count; i++)
            {
                if (listaOcenaUloga[i].Uloga == trenutnaUloga.Uloga)
                {
                    trenutnaUloga.Ocena = listaOcenaUloga[i].Ocena;
                    trenutnaUloga.Komentar = listaOcenaUloga[i].Komentar;
                }
            }
            ocenaFilma.TxtKomentarUloga.Text = trenutnaUloga.Komentar;
            switch (trenutnaUloga.Ocena)
            {
                case 1:
                    ocenaFilma.RadioButton6.Checked = true;
                    break;
                case 2:
                    ocenaFilma.RadioButton7.Checked = true;
                    break;
                case 3:
                    ocenaFilma.RadioButton8.Checked = true;
                    break;
                case 4:
                    ocenaFilma.RadioButton9.Checked = true;
                    break;
                case 5:
                    ocenaFilma.RadioButton10.Checked = true;
                    break;
                default:
                    ocenaFilma.RadioButton6.Checked = false;
                    ocenaFilma.RadioButton7.Checked = false;
                    ocenaFilma.RadioButton8.Checked = false;
                    ocenaFilma.RadioButton9.Checked = false;
                    ocenaFilma.RadioButton10.Checked = false;
                    break;
            }
        }

        public void OceniUlogu(int o)
        {
            trenutnaUloga.Ocena = o;
            PostaviTrenutnuUlogu();
        }

        public void OstaviKomentarUloga(UCOcenaFilma ocenaFilma)
        {
            trenutnaUloga.Komentar = ocenaFilma.TxtKomentarUloga.Text;
            PostaviTrenutnuUlogu();
        }

        public void PostaviTrenutnuUlogu()
        {
            for (int i = 0; i < listaOcenaUloga.Count; i++)
            {
                if (listaOcenaUloga[i].Uloga == trenutnaUloga.Uloga)
                {
                    listaOcenaUloga[i] = trenutnaUloga;
                }
            }
        }

        public void OceniFilm(int o)
        {
            ocenaFilm.Ocena = o;
        }

        public void KrajOcenjivanja(UCOcenaFilma ocenaFilma)
        {
            if (ocenaFilm.Ocena == 0)
            {
                MessageBox.Show("Morate oceniti film");
                return;
            }
            ocenaFilm.Komentar = ocenaFilma.TxtFilmKomentar.Text;
            try
            {
                if (p) 
                {
                    try
                    {
                        Communication.Instance.PromeniOcene(ocenaFilm, listaOcenaUloga);
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
                        Communication.Instance.SacuvajOcene(ocenaFilm, listaOcenaUloga);
                    }
                    catch (IOException)
                    {
                        MainCoordinator.Instance.ServerskaGreska();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Došlo je do greske");
                        Debug.WriteLine(ex.Message);
                    }
                    
                }
                
                MessageBox.Show("Uspesno ocenjen " + ocenaFilm.Film.Naziv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (og == null)
                    KorisnikCoordinator.Instance.ShowKorisnikPocetna();
                else Nazad();
            }
        }

        public void Nazad()
        {
            KorisnikCoordinator.Instance.ShowOcenaGlumca(og);
        }

        public void PrikaziGlumca(UCOcenaFilma ocenaFilma)
        {
            if(ocenaFilma.ListBoxUloge.SelectedItem != null)
            KorisnikCoordinator.Instance.ShowOcenaGlumca(ocenaFilma, trenutnaUloga.Uloga.Glumac);
        }

        public void Odstampaj()
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Newtonsoft.Json.Formatting.Indented
            };
            string json = JsonConvert.SerializeObject(prikazaniFilm,settings);

            File.WriteAllText($"C:\\Users\\radma\\source\\repos\\AleksaRadmanovac\\Jea\\AppRatingMovies\\Stampanje\\{prikazaniFilm}Output.json", json);
            MessageBox.Show(prikazaniFilm.Naziv + " uspesno preveden u Json format.");
        }

    }

}

