using Domen;
using Domen.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOLogin : OsnovaSistemskihOperacija
    {
        public bool Uspesan { get; set; }
        public object Nalog { get; set; }
        public LoginZahtev loginZahtev { get; set; }
        protected override void IzvrsiSistemskuOperaciju()
        {
            Uspesan = false;
            if (loginZahtev.Administrator)
            {
                List<IDomenObjekat> lista = repository.GetAll(new Administrator());
                foreach (IDomenObjekat objekat in lista)
                {
                    Administrator administrator = (Administrator)objekat;
                    if (administrator.Username == loginZahtev.Username && administrator.Password == loginZahtev.Password)
                    {
                        Uspesan = true;
                        Nalog = administrator;
                        break;
                    }
                }
            }
            else
            {
                List<IDomenObjekat> lista = repository.GetAll(new Korisnik());
                foreach (IDomenObjekat objekat in lista)
                {
                    Korisnik korisnik = (Korisnik)objekat;
                    if (korisnik.Username == loginZahtev.Username && korisnik.Password == loginZahtev.Password)
                    {
                        Uspesan = true;
                        Nalog = korisnik;
                        break;
                    }
                }
            }
        }
    }
}
