using Domen;
using Domen.Communication;
using Domen.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija vrati ocene filma. Vraca iz baze ocenu odredjenog korisnika za odredjeni film i njegove ocene uloga za taj film.
    /// Sadrzi u sebi atribute Odgovor, OcenaFilma, listaOcenaUloga i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOVratiOceneFilma : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za odgovor koji sadrzi ocenu filma i listu ocena za sve uloge u filmu.
        /// </summary>
        /// <value>Odgovor koji sadrzi ocenu filma i listu ocena za sve uloge u filmu.</value>
        public VratiOceneOdgovor Odgovor { get; set; }
        /// <summary>
        /// Get i set metoda za objekat ocena filma koji sadrzi film za koji se vracaju ocene i korisnika cije se ocene traze.
        /// </summary>
        /// <value>Objekat ocena filma koji sadrzi film za koji se vracaju ocene i korisnika cije se ocene traze.</value>
        public OcenaFilma OcenaFilma { get; set; }
        /// <summary>
        /// Get i set metoda za listu objekata ocena uloga koje se nalaze u filmu za koji se vracaju ocene.
        /// </summary>
        /// <value>Lista objekata ocena uloga koje se nalaze u filmu za koji se vracaju ocene.</value>
        public List<OcenaUloge> listaOcenaUloga { get; set; }
        /// <summary>
        /// Metoda za izvrsavanje sistemske operacije vrati ocene filma. 
        /// Vraca iz baze ocenu odredjenog filma od strane odredjenog korisnika, zatim tom filmu pridruzuje uloge iz tog filma
        /// i vraca ocene korisnika za te uloge, smesta sve ocene u Odgovor. Ako u bazi ne postoji ocena filma od strane korisnika dolazi do exceptiona.
        /// </summary>
        /// <exception cref="MissingOcenaException">Ako u bazi ne postoji ocena filma od strane korisnika.</exception>
        protected override void IzvrsiSistemskuOperaciju()
        {
             
            Odgovor = new VratiOceneOdgovor();
            Odgovor.OcenaFilma = (OcenaFilma)repository.Get(OcenaFilma);
            if(Odgovor.OcenaFilma== null ) throw new MissingOcenaException();
            
            Odgovor.OcenaFilma.Film.Uloge = new List<Uloga>();
            List<IDomenObjekat> lista = repository.GetAllWhere(new Uloga(), $"Where FilmID = {OcenaFilma.Film.Id}");
            foreach (IDomenObjekat objekat in lista)
            {
                Odgovor.OcenaFilma.Film.Uloge.Add((Uloga)objekat);
            }
           
            listaOcenaUloga = new List<OcenaUloge>();
            
            foreach (Uloga uloga in OcenaFilma.Film.Uloge)
            {
                OcenaUloge ou = (OcenaUloge)repository.Get(new OcenaUloge()
                {
                    Korisnik = OcenaFilma.Korisnik,
                    Uloga = uloga
                }
                );
                if(ou != null )
                listaOcenaUloga.Add(ou);
            }
            Odgovor.OceneUloga = listaOcenaUloga;
        }
    }
}
