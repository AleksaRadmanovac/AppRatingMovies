using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija sacuvaj zahtev. Dodaje film iz zahteva u bazu, dodaje zahtev u bazu i dodaje uloge iz filma u bazu.
    /// Sadrzi u sebi atribute Zahtev, FilmId i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOSacuvajZahtev : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za zahtev za dodavanje filma.
        /// </summary>
        /// <value>Zahtev za dodavanje filma.</value>
        public ZahtevZaFilm Zahtev { get; set; }
        /// <summary>
        /// Get i set metoda za id filma koji se generise iz baze nakon njegovog dodavanja u bazu.
        /// </summary>
        /// <value>Id filma koji se generise iz baze nakon njegovog dodovanja u bazu.</value>
        public int FilmId { get; set; }
        /// <summary>
        /// Metoda za izvrsavanje sistemske operacije sacuvaj zahtev.
        /// Dodaje film iz zahteva u bazu i generisani id iz baze dodeljuje FilmId-u, dodaje zahtev u bazu i dodaje uloge iz filma u bazu.
        /// </summary>
        protected override void IzvrsiSistemskuOperaciju()
        {
            FilmId = repository.AddOutput(Zahtev.Film);
            Zahtev.Film.Id = FilmId;
            repository.Add(Zahtev);
            foreach(Uloga uloga in Zahtev.Uloge) 
            {
                uloga.Film.Id = FilmId;
                repository.Add(uloga);
            }
        }
    }
}
