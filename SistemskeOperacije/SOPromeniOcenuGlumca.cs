using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija promeni ocenu glumca. Menja ocenu glumca u bazi.
    /// Sastoji se od atributa OcenaGlumca i override metode IzvrsiSistemskuOperaciju.
    /// </summary>
    public class SOPromeniOcenuGlumca : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za objekat ocene glumca kojem se menja ocena.
        /// </summary>
        /// <value>Objekat ocene glumca kojem se menja ocena.</value>
        public OcenaGlumca OcenaGlumca { get; set; }
        /// <summary>
        /// Metoda za izvrsavanje sistemske operacije promene ocene glumca. Menja ocenu glumca u bazi.
        /// </summary>
        internal override void IzvrsiSistemskuOperaciju()
        {
            repository.Update(OcenaGlumca);
        }
    }
}
