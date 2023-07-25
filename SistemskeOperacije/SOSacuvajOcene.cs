using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija sacuvaj ocene. Dodaje ocenu filma u bazu i dodaje ocene uloga u tom filmu.
    /// Sadrzi u sebi atribute OcenaFilma, ListaOcenaUloga i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskiOperacija.
    /// </summary>
    public class SOSacuvajOcene : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za objekat ocene filma za kog se cuvaju ocene.
        /// </summary>
        /// <value>Objekat ocene filma za kog se cuvaju ocene.</value>
        public OcenaFilma OcenaFilma { get; set; }
        /// <summary>
        /// Get i set metoda za listu objekata ocena uloga iz filma za kog se cuvaju ocene.
        /// </summary>
        /// <value>Lista objekata ocena uloga iz filma za kog se cuvaju ocene.</value>
        public List<OcenaUloge> ListaOcenaUloga { get; set; }
        /// <summary>
        /// Metoda za izvrsavanje sistemske operacije sacuvaj ocene. 
        /// Dodaje ocenu filma u bazu i dodaje ocene uloga u tom filmu.
        /// </summary>
        protected override void IzvrsiSistemskuOperaciju()
        {
            if(OcenaFilma != null)
            repository.Add(OcenaFilma);
            foreach(OcenaUloge o in ListaOcenaUloga) 
            {
                //if(o.Ocena != 0)
                repository.Add(o);
            }
        }
    }
}
