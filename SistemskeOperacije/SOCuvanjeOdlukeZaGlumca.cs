using Domen.Communication;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOCuvanjeOdlukeZaGlumca : OsnovaSistemskihOperacija
    {
        public ZahtevZaGlumca ZahtevZaGlumca { get; set; }
        protected override void IzvrsiSistemskuOperaciju()
        {
            repository.Update(ZahtevZaGlumca.Administrator);
            repository.Update(ZahtevZaGlumca.Glumac);
            repository.Update(ZahtevZaGlumca);
        }
    }
}
