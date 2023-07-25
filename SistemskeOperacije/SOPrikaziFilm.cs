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
    /// Sistemska operacija prikazi film. Nalazi film sa id-jem FilmID u bazi.
    /// Sastoji se od atributa FilmID, Rez i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOPrikaziFilm : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za id filma koji se prikazuje.
        /// </summary>
        /// <value>Id filma koji se prikazuje.</value>
        public int FilmID { get; set; }
        /// <summary>
        /// Get i set metoda za film koji se prikazuje.
        /// </summary>
        /// <value>Film koji se prikazuje</value>
        public Film Rez { get; set; }
        /// <summary>
        /// Metoda za izvrsavanje sistemske operacije prikazi film. Nalazi film sa id-jem FilmID u bazi i postavlja ga na
        /// vrednost atributa Rez.
        /// </summary>
        /// <exception cref="MissingFilmException">Ako dodje do greske pri citanju filma.</exception>
        protected override void IzvrsiSistemskuOperaciju()
        {
            try
            {
                Film film = (Film)repository.Get(new Film() { Id = FilmID });
                List<IDomenObjekat> listaUloga = repository.GetAllWhere(new Uloga(), $" where Uloga.FilmID = {film.Id}");
                foreach (Uloga uloga in listaUloga)
                {
                    film.Uloge.Add(uloga);
                }
                if (film.Prikazan) Rez = film;
                else { throw new MissingFilmException(); }
            }
            catch (MissingFilmException ex)
            { throw ex; }            
        }
    }
}
