using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija pronadji filmove po glumcu. Izvlaci sve filmove iz baze u kojima
    /// glumi odredjen glumac.
    /// Sastoji se od atributa ListaFilmova, GlumacID i override metode IzvrsavanjeSistemskihOperacija.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOPronadjiFilmovePoGlumcu : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za listu filmova koji su pronadjeni.
        /// </summary>
        /// <value>Lista filmova koji su pronadjeni.</value>
        public List<Film> ListaFilmova { get; set; }
        /// <summary>
        /// Get i set metoda za id glumca za kog se traze filmovi.
        /// </summary>
        /// <value>Id glumca za kog se traze filmovi.</value>
        public int GlumacID { get; set; }
        /// <summary>
        /// Metod za izvrsavanje sistemske operacije pronadji filmove po glumcu. Izvlaci sve filmove iz baze u kojima
        /// glumi glumac koji ima GlumacID i smesta ih u ListaFilmova.
        /// </summary>
        protected override void IzvrsiSistemskuOperaciju()
        {
            ListaFilmova = new List<Film>();
            List<IDomenObjekat> lista = repository.GetAllWhere(new Film(),$"LEFT JOIN Uloga ON Film.ID = Uloga.FilmID LEFT JOIN Glumac ON Uloga.GlumacID = Glumac.ID WHERE Glumac.Id = {GlumacID} AND Film.Prikazan = 1");
            foreach (Film film in lista)
            {
                List<IDomenObjekat> listaUloga = repository.GetAllWhere(new Uloga(), $" where Uloga.FilmID = {film.Id}");
                foreach (Uloga uloga in listaUloga)
                {
                    film.Uloge.Add(uloga);
                }
                ListaFilmova.Add(film);
            }
        }
    }
}
