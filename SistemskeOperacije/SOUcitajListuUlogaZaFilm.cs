using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija ucitaj listu uloga za film. Vraca iz baze sve uloge koje se nalaze u odredjenom filmu.
    /// Sadrzi u sebi atribute FilmID, ListaUloga i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOUcitajListuUlogaZaFilm : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za id filma za koji se traze uloge.
        /// </summary>
        /// <value>Id filma za koji se traze uloge.</value>
        public int FilmID { get; set; }
        /// <summary>
        /// Get i set metoda za listu uloga koje se nalaze u zadatom filmu.
        /// </summary>
        /// <value>Lista uloga koje se nalaze u zadatom filmu.</value>
        public List<Uloga> ListaUloga { get; set; }
        /// <summary>
        /// Metoda za izvrsavanje sistemske operacije ucitaj listu uloga za film. 
        /// Vraca iz baze sve uloge koje se nalaze u odredjenom filmu i dodaje ih u ListaUloga.
        /// </summary>
        internal override void IzvrsiSistemskuOperaciju()
        {
            ListaUloga = new List<Uloga>();
            List<IDomenObjekat> lista = repository.GetAll(new Uloga());
            foreach(IDomenObjekat objekat in lista) 
            {
                if(((Uloga)objekat).Film.Id == FilmID) ListaUloga.Add((Uloga)objekat);
            }
        }
    }
}
