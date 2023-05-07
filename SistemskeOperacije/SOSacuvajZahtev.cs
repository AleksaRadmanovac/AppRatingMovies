using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOSacuvajZahtev : OsnovaSistemskihOperacija
    {
        public ZahtevZaFilm Zahtev { get; set; }
        public int FilmId { get; set; }
        protected override void IzvrsiSistemskuOperaciju()
        {
            FilmId = repository.AddOutput(Zahtev.Film);
            Zahtev.Film.Id = FilmId;
            repository.Add(Zahtev);
            foreach(Uloga uloga in Zahtev.Uloge) 
            {
                uloga.Film.Id = FilmId;
                repository.Add(uloga);
            }
        }
    }
}
