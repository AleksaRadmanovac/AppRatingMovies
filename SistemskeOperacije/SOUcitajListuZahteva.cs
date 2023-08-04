using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija ucitaj listu zahteva. Vraca sve neobradjane zahteve za unos filma iz baze.
    /// Sadrzi u sebi atribut ListaZahteva i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOUcitajListuZahteva : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za listu neobradjenih zahteva za unos filma.
        /// </summary>
        /// <value>Lista neobradjenih zahteva za unos filma.</value>
        public List<ZahtevZaFilm> ListaZahteva { get; set; }
        /// <summary>
        /// Metoda za izvrsavanje sistemske operacije ucitaj listu zahteva. Vraca sve zahteve za unos filma iz baze,
        /// proverava koji su neobradjeni i dodaje ih u ListaZahteva.
        /// </summary>
        internal override void IzvrsiSistemskuOperaciju()
        {
            ListaZahteva = new List<ZahtevZaFilm>();
            List<IDomenObjekat> lista = repository.GetAll(new ZahtevZaFilm());
            foreach (IDomenObjekat objekat in lista)
            {
                if (!((ZahtevZaFilm)objekat).Obradjen)
                {
                    List<IDomenObjekat> listaUloga = repository.GetAllWhere(new Uloga(), $" where Uloga.FilmID = {((ZahtevZaFilm)objekat).Film.Id}");
                    foreach (Uloga uloga in listaUloga)
                    {
                        ((ZahtevZaFilm)objekat).Uloge.Add(uloga);
                    }
                    ListaZahteva.Add((ZahtevZaFilm)objekat);
                }
            }
        }
    }
}
