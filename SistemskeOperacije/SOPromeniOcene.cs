using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija promeni ocene filma. Menja ocenu filma u bazi, kao i ocene svih uloga iz tog filma u bazi.
    /// Sastoji se od atributa OcenaFilma, ListaOcenaUloga i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOPromeniOcene : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za objekat ocene filma kojem se menja ocena.
        /// </summary>
        /// <value>Objekat ocene filma kojem se menja ocena.</value>
        public OcenaFilma OcenaFilma { get; set; }
        /// <summary>
        /// Get i set metoda za listu objekata ocene uloga u filmu.
        /// </summary>
        /// <value>Lista objekata ocene uloga u filmu.</value>
        public List<OcenaUloge> ListaOcenaUloga { get; set; }
        /// <summary>
        /// Metoda za izvrsavanje sistemske operacije promene ocene filma. Menja ocenu filma u bazi, kao i ocene svih uloga iz tog filma u bazi.
        /// </summary>
        protected override void IzvrsiSistemskuOperaciju()
        {
            repository.Update(OcenaFilma);
            foreach (OcenaUloge o in ListaOcenaUloga)
            {
                //if(o.Ocena != 0)
                repository.Update(o);
            }
        }
    }
}
