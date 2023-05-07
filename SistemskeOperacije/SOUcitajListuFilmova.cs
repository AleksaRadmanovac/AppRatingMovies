using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOUcitajListuFilmova : OsnovaSistemskihOperacija
    {
        public List<Film> UcitanaLista { get; set; }

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
