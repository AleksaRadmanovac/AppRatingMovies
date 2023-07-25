using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacije vrati sve ocene za glumca. Vraca iz baze sve ocene svih korisnika za odredjenog glumca.
    /// Sadrzi u sebi atribut Glumac i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOVratiSveOceneZaGlumca : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za glumca za koji se vracaju sve ocene.
        /// </summary>
        /// <value>Glumac za koji se vracaju sve ocene.</value>
        public Glumac Glumac { get; set; }
        /// <summary>
        /// Metoda za izvrsavanje sistemske operacije vrati sve ocene za glumca. Vraca iz baze sve ocene za zadatog glumca,
        /// pridruzuje ih atributu Glumac.
        /// </summary>
        protected override void IzvrsiSistemskuOperaciju()
        {
            List<IDomenObjekat> listaOg = repository.GetAllWhere(new OcenaGlumca(), $"Where GlumacID = {Glumac.Id}");
            foreach (IDomenObjekat og in listaOg)
            {
                if(og!=null)
                Glumac.Ocene.Add((OcenaGlumca)og);
            }
        }
    }
}
