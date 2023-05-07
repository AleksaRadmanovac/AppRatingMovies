using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOUcitajListuUlogaZaFilm : OsnovaSistemskihOperacija
    {
        public int FilmID { get; set; }
        public List<Uloga> ListaUloga { get; set; }
        protected override void IzvrsiSistemskuOperaciju()
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
