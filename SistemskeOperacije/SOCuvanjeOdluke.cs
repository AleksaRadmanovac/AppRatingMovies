using Domen;
using Domen.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija cuvanja odluke koju je administrator doneo povodom unosa filma iz zahteva u prikazane filmove
    /// ili dodavanje uloga postojecem filmu.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOCuvanjeOdluke : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Zahtev za unos filma u prikazane filmove ili dodavanje uloga postojecem filmu.
        /// </summary>
        public ZahtevZaFilm ZahtevZaFilm { get; set; }

        /// <summary>
        /// Boolean koji pokazuje da li se radi o unosu filma u prikazane filmove ili dodavanju uloga postojecem filmu.
        /// True se dodaju uloge u postojeci film, false ako se unosi film u prikazane filmove.
        /// </summary>
        public bool DodavanjeUloga { get; set; }
        protected override void IzvrsiSistemskuOperaciju()
        {
            repository.Update(ZahtevZaFilm);
            repository.Update(ZahtevZaFilm.Administrator);
            if (DodavanjeUloga)
            {
                foreach (Uloga uloga in ZahtevZaFilm.Uloge)
                {
                    repository.Add(uloga);
                    uloga.Film = ZahtevZaFilm.Film;
                    repository.Delete(uloga);
                }
                
            }
            else
            {
                if (ZahtevZaFilm.Odobren)
                {
                    repository.Update(ZahtevZaFilm.Film);
                }
                if (!ZahtevZaFilm.Odobren)
                {
                    foreach (Uloga uloga in ZahtevZaFilm.Uloge) repository.Delete(uloga);                  
                }
            }
        }
    }
}
