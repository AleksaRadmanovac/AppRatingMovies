using DbBroker;
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
    /// Sistemska operacija prikazi glumca. Nalazi glumca sa id-jem GlumacID u bazi.
    /// Sastoji se od atributa GlumacID, Rez i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOPrikaziGlumca : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za id glumca koji se prikazuje.
        /// </summary>
        /// <value>Id glumca koji se prikazuje.</value>
        public int GlumacID { get; set; }
        /// <summary>
        /// Get i set metoda za glumca koji se prikazuje.
        /// </summary>
        /// <value>Glumac koji se prikazuje</value>
        public Glumac Rez { get; set; }
        /// <summary>
        /// Metoda za izvrsavanje sistemske operacije prikazi glumca. Nalazi glumca sa id-jem GlumacID u bazi i postavlja ga na
        /// vrednost atributa Rez.
        /// </summary>
        /// <exception cref="MissingGlumacException">Ako dodje do greske pri citanju glumca.</exception>
        protected override void IzvrsiSistemskuOperaciju()
        {
            try
            {
                Glumac glumac = (Glumac)repository.Get(new Glumac() { Id = GlumacID });
                if (glumac.Prikazan) Rez = glumac;
                else { throw new MissingGlumacException(); }
            }
            catch (MissingGlumacException ex) { throw ex; }
        }
    }
}
