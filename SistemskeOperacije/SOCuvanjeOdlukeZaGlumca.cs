using Domen.Communication;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija cuvanja odluke za glumca. Azurira podatke u bazi podataka o broju obradjenih zahteva kod administratora,
    /// prikazanost glumca, kao i podatke o samom zahtevu. U sebi sadrzi atribut ZahtevZaGlumca i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOCuvanjeOdlukeZaGlumca : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za zahtev za unos glumca u prikazane glumce.
        /// </summary>
        /// <value>Zahtev za unos glumca u prikazane glumce.</value>
        public ZahtevZaGlumca ZahtevZaGlumca { get; set; }
        /// <summary>
        /// Metoda koja izvrsava sistemsku operaciju cuvanja odluke za glumca. Azurira podatke u bazi podataka o broju obradjenih zahteva kod administratora,
        /// prikazanost glumca, kao i podatke o samom zahtevu.
        /// </summary>
        protected override void IzvrsiSistemskuOperaciju()
        {
            repository.Update(ZahtevZaGlumca.Administrator);
            repository.Update(ZahtevZaGlumca.Glumac);
            repository.Update(ZahtevZaGlumca);
        }
    }
}
