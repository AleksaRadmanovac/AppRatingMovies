using DbBroker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija zahtev za glumca. Dodaje glumca iz zahteva u bazu i dodaje sam zahtev u bazu.
    /// Sadrzi u sebi atribut Zahtev i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOSacuvajZahtevZaGlumca : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za zahtev za dodavanje novog glumca.
        /// </summary>
        /// <value>Zahtev za dodavanje novog glumca.</value>
        public ZahtevZaGlumca Zahtev { get; set; }
        /// <summary>
        /// Metoda za izvrsavanje sistemske operacije zahtev za glumca. Dodaje glumca u bazu i na id glumca postavlja generisani id, dodaje zahtev u bazu.
        /// </summary>
        internal override void IzvrsiSistemskuOperaciju()
        {
            Zahtev.Glumac.Id = repository.AddOutput(Zahtev.Glumac);
            repository.Add(Zahtev);
        }
    }
}
