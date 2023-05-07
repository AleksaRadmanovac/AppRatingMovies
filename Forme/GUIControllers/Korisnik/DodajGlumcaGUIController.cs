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
    public class DodajGlumcaGUIController
    {
        UCDodajFilm dF;
        public DodajGlumcaGUIController(UCDodajGlumca dodajGlumca)
        {
            dodajGlumca.CmbBoxPol.DataSource = Enum.GetValues(typeof(Pol));    
        }

        public DodajGlumcaGUIController(UCDodajGlumca dodajGlumca, UCDodajFilm dodajFilm)
        {
            dodajGlumca.CmbBoxPol.DataSource = Enum.GetValues(typeof(Pol));
            dF = dodajFilm;
        }
        public void PodnesiZahtev(UCDodajGlumca dodajGlumca)
        {
            /*if (!dodajGlumca.TxtGodiste.Text.All(char.IsDigit)) 
            {
                MessageBox.Show("Godiste moze da sadrzi samo brojeve");
            }*/
            if (dodajGlumca.TxtIme.TextLength == 0 || dodajGlumca.TxtBoxPrezime.TextLength == 0 || dodajGlumca.TxtGodiste.TextLength == 0)
            {
                MessageBox.Show("Morate popuniti sva polja");
                return;
            }
            ZahtevZaGlumca zahtevZaGlumca = new ZahtevZaGlumca();
            zahtevZaGlumca.Glumac = new Glumac();
            zahtevZaGlumca.Glumac.Ime = dodajGlumca.TxtIme.Text;
            zahtevZaGlumca.Glumac.Prezime = dodajGlumca.TxtBoxPrezime.Text;
            zahtevZaGlumca.Glumac.Godiste = int.Parse(dodajGlumca.TxtGodiste.Text);
            zahtevZaGlumca.Glumac.Pol = (Pol)dodajGlumca.CmbBoxPol.SelectedItem;
            try
            {
                Communication.Instance.PodnesiZahtevZaGlumca(zahtevZaGlumca);
                MessageBox.Show("Uspesno ste podneli zahtev za unos glumca");
                if (dF == null)
                {
                    KorisnikCoordinator.Instance.ShowKorisnikPocetna();
                }
                else
                {
                    KorisnikCoordinator.Instance.ReturnToDodajGlumca(dF);
                }
            }
            catch (IOException) 
            {
                MainCoordinator.Instance.ServerskaGreska();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
