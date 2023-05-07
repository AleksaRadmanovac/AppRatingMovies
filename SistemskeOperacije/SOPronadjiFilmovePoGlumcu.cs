using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOPronadjiFilmovePoGlumcu : OsnovaSistemskihOperacija
    {
        public List<Film> ListaFilmova { get; set; }
        public int GlumacID { get; set; }

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
