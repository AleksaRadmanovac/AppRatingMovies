using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    ///  Sistemska operacija ucitaj listu filmova. Vraca iz baze sve filmove koji su oznaceni kao prikazani.
    ///  Sadrzi u sebi atribut UcitanaLista i override metode IzvrsiSistemskuOperaciju.
    ///  Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOUcitajListuFilmova : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za listu svih ucitanih filmova.
        /// </summary>
        /// <value>Lista svih ucitanih filmova.</value>
        public List<Film> UcitanaLista { get; set; }
        /// <summary>
        /// Metoda za izvrsavanje sistemske operacije ucitaj listu filmova. Vraca iz baze sve filmove koji su oznaceni kao prikazani.
        /// Zatim svakom pridruzuje uloge iz tih filmova i dodaje filmove u UcitanaLista.
        /// </summary>
        protected override void IzvrsiSistemskuOperaciju()
        {
            UcitanaLista= new List<Film>();
            List<IDomenObjekat> lista = repository.GetAllWhere(new Film(), $"WHERE Prikazan = 1");
            foreach (IDomenObjekat objekat in lista)
            {
                List<IDomenObjekat> listaUloga = repository.GetAllWhere(new Uloga(), $" WHERE FilmID = {((Film)objekat).Id}");
                foreach (Uloga uloga in listaUloga)
                {
                    ((Film)objekat).Uloge.Add(uloga);
                }
                UcitanaLista.Add((Film)objekat);
            }      
        }
    }
}
