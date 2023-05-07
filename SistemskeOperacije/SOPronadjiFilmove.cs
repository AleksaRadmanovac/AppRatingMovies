using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOPronadjiFilmove : OsnovaSistemskihOperacija
    {
        public List<Film> ListaFilmova { get; set; }
        public string Kriterijum { get; set; }

        protected override void IzvrsiSistemskuOperaciju()
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
