using Domen;
using Domen.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija login. Proverava da li se radi o logovanju administratora ili obicnog korisnika.
    /// Proverava da li se username i password poklapaju sa nekim nalogom u bazi.
    /// Sastoji se od atributa Uspesan, Nalog, loginZahtev i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOLogin : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za boolean koji predstavlja da li je login bio uspesan ili ne.
        /// </summary>
        /// <value>Da li je login bio uspesan. True - da, False - ne.</value>
        public bool Uspesan { get; set; }
        /// <summary>
        /// Get i set metoda koja predstavlja nalog koji pokusava login.
        /// </summary>
        /// <value>Nalog koji pokusava login.</value>
        public object Nalog { get; set; }
        /// <summary>
        /// Get i set metoda za loginZahtev koji u sebi sadrzi username, password i boolean administrator koji pokazuje
        /// da li se radi o administratoru.
        /// </summary>
        /// <value>loginZahtev koji u sebi sadrzi username, password i boolean administrator koji pokazuje
        /// da li se radi o administratoru.</value>
        public LoginZahtev loginZahtev { get; set; }
        /// <summary>
        /// Metoda koja izvrsava sistemsku operaciju login. Proverava da li se radi o logovanju administratora ili obicnog korisnika.
        /// Proverava da li se username i password poklapaju sa nekim nalogom u bazi, ako je pronadjena, postavlja atribut Nalog na tu vrednost i boolean Uspesan na True,
        /// u suprotnom boolean Uspesan postavlja na False.
        /// </summary>
        internal override void IzvrsiSistemskuOperaciju()
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
