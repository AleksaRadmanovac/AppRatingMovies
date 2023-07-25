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
    /// Sistemska operacija ucitavanje zahteva. Vraca odredjen zahtev iz baze.
    /// Sadrzi u sebi atribute ZahtevZaFilm, Id i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOUcitavanjeZahteva : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za zahtev za film koji se ucitava.
        /// </summary>
        /// <value>Zahtev za film koji se ucitava.</value>
        public ZahtevZaFilm ZahtevZaFilm { get; set; }
        /// <summary>
        /// Get i set metoda za id zahteva za film koji se ucitava.
        /// </summary>
        /// <value>Id zahteva za film koji se ucitava.</value>
        public int Id { get; set; }
        /// <summary>
        /// Metoda za sistemsku operaciju ucitavanje zahteva. Vraca iz baze zahtev po Id-u, ako je dati zahtev obradjen, dolazi do exceptiona.
        /// </summary>
        /// <exception cref="MissingZahtevException">Ako je zahtev vec obradjen.</exception>
        protected override void IzvrsiSistemskuOperaciju()
        {
            ZahtevZaFilm zahtev = (ZahtevZaFilm)repository.Get(new ZahtevZaFilm() { Id = this.Id });
            if (!zahtev.Obradjen) ZahtevZaFilm = zahtev;
            else { throw new MissingZahtevException(); }
        }
    }
}
