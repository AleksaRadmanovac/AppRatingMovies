using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija ucitaj listu zahteva za glumca. Vraca sve neobradjane zahteve za unos glumca iz baze.
    /// Sadrzi u sebi atribut ListaZahtevaZaGlumca i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOUcitajListuZahtevaZaGlumca : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za listu neobradjenih zahteva za unos glumca.
        /// </summary>
        /// <value>Lista neobradjenih zahteva za unos glumca.</value>
        public List<ZahtevZaGlumca> ListaZahtevaZaGlumca { get; set; }
        /// <summary>
        /// Metoda za izvrsavanje sistemske operacije ucitaj listu zahteva za glumca. Vraca sve zahteve za unos glumca iz baze,
        /// proverava koji su neobradjeni i dodaje ih u ListaZahtevaZaGlumca.
        /// </summary>
        protected override void IzvrsiSistemskuOperaciju()
        {
            ListaZahtevaZaGlumca = new List<ZahtevZaGlumca>();
            List<IDomenObjekat> lista = repository.GetAll(new ZahtevZaGlumca());
            foreach (IDomenObjekat objekat in lista)
            {
                if (!((ZahtevZaGlumca)objekat).Obradjen) ListaZahtevaZaGlumca.Add((ZahtevZaGlumca)objekat);
            }
        }
    }
}
