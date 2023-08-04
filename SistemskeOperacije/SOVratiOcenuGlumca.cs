using Domen;
using Domen.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija vrati ocenu glumca. Vraca iz baze ocenu odredjenog korisnika za odredjenog glumca.
    /// Sadrzi u sebi atribut OcenaGlumca i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOVratiOcenuGlumca : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za objekat ocene glumca za odredjenog glumca od strane odredjenog korisnika.
        /// </summary>
        /// <value>Objekat ocene glumca za odredjenog glumca od strane odredjenog korisnika.</value>
        public OcenaGlumca OcenaGlumca { get; set; }
        /// <summary>
        /// Metoda za izvrsvanje sistemske operacije vrati ocenu glumca.
        /// Vraca iz baze ocenu glumca iz atributa OcenaGlumca od strane korisnika iz atributa OcenaGlumca.
        /// Ako ne postoji OcenaGlumca u bazi dolazi do exceptiona.
        /// </summary>
        /// <exception cref="MissingOcenaException">Ako ne postoji OcenaGlumca u bazi.</exception>
        internal override void IzvrsiSistemskuOperaciju()
        {

                OcenaGlumca = (OcenaGlumca)repository.Get(OcenaGlumca);
                if(OcenaGlumca== null ) { throw new MissingOcenaException(); }
        }
    }
}
