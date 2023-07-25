using Domen;
using Domen.Communication;
using Domen.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija registracija. Proverava da li vec postoji korisnik sa istim username-om, ako ne postoji
    /// dodaje novog korisnika u bazu.
    /// Sadrzi u sebi atribut Korisnik i override metode IzvrsioSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SORegistracija : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za korisnika koji se registruje.
        /// </summary>
        /// <value>Korisnik koji se registruje.</value>
        public Korisnik Korisnik { get; set; }

        /// <summary>
        /// Metoda za izvsravanje sistemske operacije registracija. Proverava da li vec postoji korisnik sa istim username-om,
        /// ako ne postoji dodaje novog korisnika u bazu, ako postoji baca exception.
        /// </summary>
        /// <exception cref="UsernamePostojiException">Ako u bazi vec postoji korisnik sa istim username-om.</exception>
        protected override void IzvrsiSistemskuOperaciju()
        {
           List<IDomenObjekat> lista = repository.GetAll(Korisnik);
            bool p = true;
            foreach (IDomenObjekat korisnik in lista)
            {
                if (((Korisnik)korisnik).Username == Korisnik.Username) p = false;
            }
            if (p)
            {
                repository.Add(Korisnik);
            }
            else
            {
                throw new UsernamePostojiException();
            }
        }
    }
}
