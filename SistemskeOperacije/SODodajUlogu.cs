using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija dodavanja uloge. Dodaje ulogu u bazu podataka.
    /// U sebi sadrzi atribut Uloga i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SODodajUlogu : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za ulogu koja se dodaje.
        /// </summary>
        /// <value>Uloga koja se dodaje.</value>
        public Uloga Uloga { get; set; }

        /// <summary>
        /// Metoda koja izvrsava sistemsku operaciju dodavanja uloge. Dodaje ulogu u bazu podataka.
        /// </summary>
        internal override void IzvrsiSistemskuOperaciju()
        {
            repository.Add(Uloga);
        }
    }
}
