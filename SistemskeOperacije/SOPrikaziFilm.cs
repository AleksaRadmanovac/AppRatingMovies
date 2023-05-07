using Domen;
using Domen.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOPrikaziFilm : OsnovaSistemskihOperacija
    {
        public int FilmID { get; set; }
        public Film Rez { get; set; }
        protected override void IzvrsiSistemskuOperaciju()
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
    }
}
