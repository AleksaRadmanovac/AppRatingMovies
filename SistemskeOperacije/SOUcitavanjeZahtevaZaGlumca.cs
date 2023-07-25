using Domen;
using Domen.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija ucitavanje zahteva za glumca. Vraca odredjen zahtev iz baze.
    /// Sadrzi u sebi atribute ZahtevZaGlumca, Id i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOUcitavanjeZahtevaZaGlumca : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za zahtev za glumca koji se ucitava.
        /// </summary>
        /// <value>Zahtev za glumca koji se ucitava.</value>
        public ZahtevZaGlumca ZahtevZaGlumca { get; set; }
        /// <summary>
        /// Get i set metoda za id zahteva za glumca koji se ucitava.
        /// </summary>
        /// <value>Id zahteva za glumca koji se ucitava.</value>
        public int Id { get; set; }
        /// <summary>
        /// Metoda za sistemsku operaciju ucitavanje zahteva za glumca. Vraca iz baze zahtev za glumca po Id-u, ako je dati zahtev obradjen, dolazi do exceptiona.
        /// </summary>
        /// <exception cref="MissingZahtevException">Ako je zahtev vec obradjen.</exception>
        protected override void IzvrsiSistemskuOperaciju()
        {
            ZahtevZaGlumca zahtev = (ZahtevZaGlumca)repository.Get(new ZahtevZaGlumca() { Id = this.Id });
            if (!zahtev.Obradjen) ZahtevZaGlumca = zahtev;
            else { throw new MissingZahtevException(); }
        }
    }
}
