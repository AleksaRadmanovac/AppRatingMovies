using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija pronadji glumce. Pronalazi glumce iz baze po zadatom 
    /// kriterijumu.
    /// Sadrzi u sebi atribute ListaGlumaca, Kriterijum i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOPronadjiGlumce : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za listu glumaca koji su pronadjeni.
        /// </summary>
        /// <value>Lista glumaca koji su pronadjeni.</value>
        public List<Glumac> ListaGlumaca { get; set; }
        /// <summary>
        /// Get i set metoda za kriterijum po kojem se pretrazuje.
        /// </summary>
        /// <value>Kriterijum po kojem se pretrazuje.</value>
        public string Kriterijum { get; set; }
        /// <summary>
        /// Sistemska operacija pronadji glumce. Pronalazi glumce iz baze po zadatom 
        /// kriterijumu i smesta ih u ListaGlumaca.
        /// </summary>
        internal override void IzvrsiSistemskuOperaciju()
        {
            ListaGlumaca = new List<Glumac>();
            List<IDomenObjekat> lista = repository.Search(Kriterijum, new Glumac());
            foreach(IDomenObjekat objekat in lista) 
            {
                if(((Glumac)objekat).Prikazan)
                ListaGlumaca.Add((Glumac)objekat);
            }
        }
    }
}
