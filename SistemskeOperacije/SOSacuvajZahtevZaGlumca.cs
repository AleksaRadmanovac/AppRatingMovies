using DbBroker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOSacuvajZahtevZaGlumca : OsnovaSistemskihOperacija
    {
        public ZahtevZaGlumca Zahtev { get; set; }
        protected override void IzvrsiSistemskuOperaciju()
        {
            Zahtev.Glumac.Id = repository.AddOutput(Zahtev.Glumac);
            repository.Add(Zahtev);
        }
    }
}
