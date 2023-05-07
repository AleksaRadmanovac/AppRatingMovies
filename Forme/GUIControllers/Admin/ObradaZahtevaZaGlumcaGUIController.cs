using Domen;
using Forme.UserControls.Admin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.GUIControllers.Admin
{
    public class ObradaZahtevaZaGlumcaGUIController
    {
        ZahtevZaGlumca zg;
        public ObradaZahtevaZaGlumcaGUIController(UCObradaZahtevaZaGlumca obradaZahteva, ZahtevZaGlumca zahtevZaGlumca) 
        {
            zg = zahtevZaGlumca;
            zg.Obradjen = true;
            zg.Administrator = AdministratorCoordinator.Instance.Administrator;
            obradaZahteva.LblIme.Text += zahtevZaGlumca.Glumac.Ime;
            obradaZahteva.LblPrezime.Text += zahtevZaGlumca.Glumac.Prezime;
            obradaZahteva.LblGodiste.Text += zahtevZaGlumca.Glumac.Godiste;
            obradaZahteva.LblPol.Text += zahtevZaGlumca.Glumac.Pol;
        }

        public void Proveri()
        {
            KorisnikCoordinator.Instance.ShowFrmKorisnik(null);
        }

        public void Odobri()
        {
            zg.Odobren = true;
            zg.Glumac.Prikazan = true;            
            try
            {
                AdministratorCoordinator.Instance.Administrator.BrojObradjenihZahteva++;
                try
                {
                    Communication.Instance.SacuvajOdlukuZaGlumca(zg);
                }
                catch (IOException)
                {
                    MainCoordinator.Instance.ServerskaGreska();
                }
                Communication.Instance.SacuvajOdlukuZaGlumca(zg);
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
                    Communication.Instance.SacuvajOdlukuZaGlumca(zg);
                }
                catch (IOException)
                {
                    MainCoordinator.Instance.ServerskaGreska();
                }
                Communication.Instance.SacuvajOdlukuZaGlumca(zg);
                MessageBox.Show("Uspesno obradjen zahtev");

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                AdministratorCoordinator.Instance.ShowAdministratorPocetka();
            }
        }

    }
}
