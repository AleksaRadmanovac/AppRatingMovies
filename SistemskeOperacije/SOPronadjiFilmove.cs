using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija pronadji filmove. Pronalazi filmove iz baze po zadatom 
    /// kriterijumu.
    /// Sadrzi atribute ListaFilmova, Kriterijum i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOPronadjiFilmove : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za listu filmova koji su pronadjeni.
        /// </summary>
        /// <value>Lista filmova koji su pronadjeni.</value>
        public List<Film> ListaFilmova { get; set; }
        /// <summary>
        /// Get i set metoda za kriterijum po kojem se pretrazuje.
        /// </summary>
        /// <value>Kriterijum po kojem se pretrazuje.</value>
        public string Kriterijum { get; set; }
        /// <summary>
        /// Metoda za izvrsavanje sistemske operacije pronadji filmove. Pronalazi filmove iz baze po zadatom 
        /// kriterijumu i smesta ih u ListaFilmova.
        /// </summary>
        internal override void IzvrsiSistemskuOperaciju()
        {
            ListaFilmova = new List<Film>();
            List<IDomenObjekat> lista = repository.Search(Kriterijum, new Film());
            foreach(IDomenObjekat objekat in lista) 
            {
               // if (((Film)objekat).Prikazan)
                //{
                    List<IDomenObjekat> listaUloga = repository.GetAllWhere(new Uloga(), $" where Uloga.FilmID = {((Film)objekat).Id}");
                    foreach (Uloga uloga in listaUloga)
                    {
                        ((Film)objekat).Uloge.Add(uloga);
                    }
                    ListaFilmova.Add((Film)objekat);
               // }
            }
        }
    }
}
