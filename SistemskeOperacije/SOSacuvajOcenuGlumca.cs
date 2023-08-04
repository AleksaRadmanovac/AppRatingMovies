using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija sacuvaj ocenu glumca. Dodaje ocenu glumca u bazu.
    /// Sadrzi u sebi atribut OcenaGlumca i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOSacuvajOcenuGlumca : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za objekat ocena glumca.
        /// </summary>
        /// <value>Objekat ocena glumca.</value>
        public OcenaGlumca OcenaGlumca{ get; set; }
        /// <summary>
        /// Metoda za izvrsavanje sistemske operacije sacuvaj ocenu glumca. 
        /// </summary>
        internal override void IzvrsiSistemskuOperaciju()
        {
            repository.Add(OcenaGlumca);
        }
    }
}
