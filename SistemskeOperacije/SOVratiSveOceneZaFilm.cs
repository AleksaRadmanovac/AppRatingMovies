using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija vrati sve ocene za film. Vraca iz baze sve ocene svih korisnika za odredjeni film i za
    /// sve uloge u tom filmu.
    /// Sadrzi u sebi atribut Film i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOVratiSveOceneZaFilm : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za film za koji se vracaju sve ocene.
        /// </summary>
        /// <value>Film za koji se vracaju sve ocene.</value>
        public Film Film { get; set; }


        /// <summary>
        /// Metoda za izvrsavanje sistemske operacije vrati sve ocene za film. Vraca iz baze sve ocene za zadati film,
        /// i sve ocene za svaku ulogu u tom filmu i pridruzuje ih atributu Film.
        /// </summary>
        internal override void IzvrsiSistemskuOperaciju()
        {
            List<IDomenObjekat> listaOf = repository.GetAllWhere(new OcenaFilma(), $"Where FilmID = {Film.Id}");
            foreach(OcenaFilma of in listaOf ) 
            {
                Film.Ocene.Add(of);
            }

            foreach (Uloga u in Film.Uloge)
            {
                List<IDomenObjekat> listaOu = repository.GetAllWhere(new OcenaUloge(), $"Where Uloga.FilmID = {u.Film.Id} AND Uloga.GlumacID = {u.Glumac.Id}");
                foreach (IDomenObjekat ou in listaOu)
                { 
                    u.Ocene.Add((OcenaUloge)ou);
                }
            }
        }
    }
}
