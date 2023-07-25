using DbBroker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija ucitaj listu glumaca. Vraca iz baze sve glumce koji su oznaceni kao prikazani.
    /// Sadrzi u sebi atribut UcitanaLista i override metoda IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOUcitajListuGlumaca : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za lista svih ucitanih glumaca.
        /// </summary>
        /// <value>Lista svih ucitanih glumaca.</value>
        public List<Glumac> UcitanaLista { get; set; }
        /// <summary>
        /// Metoda za izvrsavanje sistemske operacije ucitaj listu glumaca. Vraca iz baze sve glumce koji su oznaceni kao prikazani i dodaje ih u UcitanaLista.
        /// </summary>
        protected override void IzvrsiSistemskuOperaciju()
        {
            UcitanaLista = new List<Glumac>();
            List<IDomenObjekat> lista = repository.GetAllWhere(new Glumac(), $"WHERE Prikazan = 1");
            foreach (IDomenObjekat objekat in lista)
            {
                UcitanaLista.Add((Glumac)objekat);
            }
        }
    }
}
