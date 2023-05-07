using Domen;
using Domen.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOUcitavanjeZahtevaZaGlumca : OsnovaSistemskihOperacija
    {
        public ZahtevZaGlumca ZahtevZaGlumca { get; set; }
        public int Id { get; set; }
        protected override void IzvrsiSistemskuOperaciju()
        {
            ZahtevZaGlumca zahtev = (ZahtevZaGlumca)repository.Get(new ZahtevZaGlumca() { Id = this.Id });
            if (!zahtev.Obradjen) ZahtevZaGlumca = zahtev;
            else { throw new MissingZahtevException(); }
        }
    }
}
