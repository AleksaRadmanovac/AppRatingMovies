using Domen;
using Domen.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOUcitavanjeZahteva : OsnovaSistemskihOperacija
    {
        public ZahtevZaFilm ZahtevZaFilm { get; set; }
        public int Id { get; set; }
        protected override void IzvrsiSistemskuOperaciju()
        {
            ZahtevZaFilm zahtev = (ZahtevZaFilm)repository.Get(new ZahtevZaFilm() { Id = this.Id });
            if (!zahtev.Obradjen) ZahtevZaFilm = zahtev;
            else { throw new MissingZahtevException(); }
        }
    }
}
