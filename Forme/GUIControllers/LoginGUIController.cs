using Domen;
using Domen.Communication;
using Forme.Forme;
using Forme.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.GUIControllers
{
    public class LoginGUIController
    {
        //private UCLogin login;
        public bool PrijavaAdministratora = false;
        public object Nalog;


        public void KorisnikLoginOpcija(UCLogin login) 
        {
            PrijavaAdministratora = false;
            login.BtnKorisnik.Enabled = false;
            login.BtnAdministrator.Enabled = true;
        }

        public void AdministratorLoginOpcija(UCLogin login)
        {
            PrijavaAdministratora = true;
            login.BtnKorisnik.Enabled = true;
            login.BtnAdministrator.Enabled = false;
        }

        public void Prijava(UCLogin login)
        {
            LoginZahtev loginZahtev = new LoginZahtev();
            loginZahtev.Administrator = PrijavaAdministratora;
            loginZahtev.Username = login.TxtBoxUsername.Text;
            loginZahtev.Password = login.TxtBoxPassword.Text;
            LoginOdgovor loginOdgovor = new LoginOdgovor();
            try
            {
                loginOdgovor = Communication.Instance.Login(loginZahtev);
            }
            catch (IOException)
            {
                MainCoordinator.Instance.ServerskaGreska();
            }
            Nalog = loginOdgovor.Nalog;


            if (loginOdgovor.Uspesan)
            {
                if (PrijavaAdministratora)
                {
                    Administrator administrator = (Administrator)Nalog;
                    AdministratorCoordinator.Instance.ShowFrmAdministrator(administrator);
                }
                else
                {
                    Korisnik korisnik = (Korisnik)Nalog;
                    KorisnikCoordinator.Instance.ShowFrmKorisnik(korisnik);

                }
                MainCoordinator.Instance.Hide();
            }
            else
            {
                login.TxtBoxPassword.BorderStyle = BorderStyle.FixedSingle;
                login.TxtBoxPassword.BackColor = Color.IndianRed;
                login.TxtBoxUsername.BorderStyle = BorderStyle.FixedSingle;
                login.TxtBoxUsername.BackColor = Color.IndianRed;
                login.LblError.Visible = true;
                MessageBox.Show("Neuspesno logovanje");
            }
        }


        public void Registracija(UCLogin login) 
        {           
            MainCoordinator.Instance.ShowRegistracija();
        }

        public void SklanjanjeErrora(UCLogin login)
        {
            login.TxtBoxPassword.BackColor = Color.NavajoWhite;
            login.TxtBoxUsername.BackColor = Color.NavajoWhite;
            login.LblError.Visible = false;

        }


    }
}
