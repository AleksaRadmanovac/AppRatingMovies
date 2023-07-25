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
    /// ili dodavanje uloga postojecem filmu. U sebi sadrzi atribute ZahtevZaFilm, DodavanjeUloga i override metode IzvrsiSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SOCuvanjeOdluke : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za zahtev za unos filma u prikazane filmove ili dodavanje uloga postojecem filmu.
        /// </summary>
        /// <value>Zahtev za unos filma u prikazane filmove ili dodavanje uloga postojecem filmu.</value>
        public ZahtevZaFilm ZahtevZaFilm { get; set; }

        /// <summary>
        /// Get i set metoda za boolean koji pokazuje da li se radi o unosu filma u prikazane filmove ili dodavanju uloga postojecem filmu.
        /// 
        /// </summary>
        /// <value>Boolean koji pokazuje da li se radi o unosu filma u prikazane filmove ili dodavanju uloga postojecem filmu.
        /// True - dodaju se uloge u postojeci film, False - Film se unosi u prikazane filmove.</value>
        public bool DodavanjeUloga { get; set; }
        /// <summary>
        /// Metoda koja izvrsava sistemsku operaciju cuvanja odluke za film. Azurira zahtev za film u bazi podataka, kao i broj obradjenih zahteva administratoru.
        /// Zatim u zavisnosti od DodavanjeUloga, dodaje nove uloge postojecem filmu ili u zavisnosti od toga da li je film odobren,
        /// azurira ga i unosi u prikazane filmove ili brise uloge vezane za taj film.
        /// </summary>
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
