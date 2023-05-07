using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOUcitajListuZahteva : OsnovaSistemskihOperacija
    {
        public List<ZahtevZaFilm> ListaZahteva { get; set; }
        protected override void IzvrsiSistemskuOperaciju()
        {
            ListaZahteva = new List<ZahtevZaFilm>();
            List<IDomenObjekat> lista = repository.GetAll(new ZahtevZaFilm());
            foreach (IDomenObjekat objekat in lista)
            {
                if (!((ZahtevZaFilm)objekat).Obradjen)
                {
                    List<IDomenObjekat> listaUloga = repository.GetAllWhere(new Uloga(), $" where Uloga.FilmID = {((ZahtevZaFilm)objekat).Film.Id}");
                    foreach (Uloga uloga in listaUloga)
                    {
                        ((ZahtevZaFilm)objekat).Uloge.Add(uloga);
                    }
                    ListaZahteva.Add((ZahtevZaFilm)objekat);
                }
            }
        }
    }
}
