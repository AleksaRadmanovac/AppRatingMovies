using Domen;
using Domen.Communication;
using Domen.Exceptions;
using Forme.UserControls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.GUIControllers
{
    public class RegistracijaGUIController
    {

        public RegistracijaGUIController(UCRegistracija register)
        {
            register.CmbBoxPol.DataSource = Enum.GetValues(typeof(Pol));
            register.CmbBoxPol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void NazadNaLogin()
        {
            MainCoordinator.Instance.ShowLogin();
        }

        public void Registracija(UCRegistracija register)
        {
            try
            {
                if (register.TxtUsername.Text.Length < 1) 
                {
                    register.LblError.Visible = true;
                    register.TxtUsername.BorderStyle = BorderStyle.FixedSingle;
                    register.TxtUsername.BackColor = Color.IndianRed;
                    register.LblError.Text = "Morate uneti korisnicko ime";
                    register.LblError.Location = new System.Drawing.Point(115, 266);
                    SklanjanjeErroraPassword(register);
                    //MessageBox.Show("Molim vas unesite korisnicko ime");
                    return;
                }
                
                if (register.TxtPassword.Text.Length < 4) 
                {
                    register.LblError2.Visible = true;
                    register.TxtPassword.BorderStyle = BorderStyle.FixedSingle;
                    register.TxtPassword.BackColor = Color.IndianRed;
                    register.TxtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
                    register.TxtConfirmPassword.BackColor = Color.IndianRed;
                    register.LblError2.Text = "Password mora imati 4 ili vise karaktera";
                    register.LblError2.Location = new System.Drawing.Point(90, 266);
                    SklanjanjeErroraUsername(register);
                    return;
                }
                if (!(register.TxtPassword.Text == register.TxtConfirmPassword.Text))
                {
                    register.LblError2.Visible = true;
                    register.TxtPassword.BorderStyle = BorderStyle.FixedSingle;
                    register.TxtPassword.BackColor = Color.IndianRed;
                    register.TxtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
                    register.TxtConfirmPassword.BackColor = Color.IndianRed;
                    register.LblError2.Text = "Vase sifre se ne poklapaju";
                    register.LblError2.Location = new System.Drawing.Point(120, 266);
                    SklanjanjeErroraUsername(register);
                    return;
                }
                Korisnik korisnik = new Korisnik();
                korisnik.Username = register.TxtUsername.Text;
                korisnik.Password = register.TxtPassword.Text;
                korisnik.Pol = (Pol)Enum.Parse(typeof(Pol), register.CmbBoxPol.Text);
                try
                {
                    Communication.Instance.Registracija(korisnik);
                }
                catch (IOException)
                {
                    MainCoordinator.Instance.ServerskaGreska();
                }
                
                MessageBox.Show("Uspesna Registracija");
                NazadNaLogin();
            }
            catch (UsernamePostojiException)
            {
                register.LblError.Visible = true;
                register.TxtUsername.BorderStyle = BorderStyle.FixedSingle;
                register.TxtUsername.BackColor = Color.IndianRed;
                register.LblError.Text = "Korisnicko ime je zauzeto";
                register.LblError.Location = new System.Drawing.Point(120, 266);
                SklanjanjeErroraPassword(register);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske");
                Debug.WriteLine(ex.Message);
            }
            //Console.WriteLine(korisnik.Pol);
            //Console.WriteLine((int)korisnik.Pol);
        }

        public void SklanjanjeErroraUsername(UCRegistracija register) 
        {
            register.TxtUsername.BackColor = Color.NavajoWhite;
            register.LblError.Visible = false;
        }
        public void SklanjanjeErroraPassword(UCRegistracija register)
        {
            register.TxtPassword.BackColor = Color.NavajoWhite;
            register.TxtConfirmPassword.BackColor = Color.NavajoWhite;
            register.LblError2.Visible = false;
        }



    }
}
