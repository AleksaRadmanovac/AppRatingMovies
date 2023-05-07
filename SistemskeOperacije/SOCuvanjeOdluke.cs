using Domen;
using Domen.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOCuvanjeOdluke : OsnovaSistemskihOperacija
    {
        public ZahtevZaFilm ZahtevZaFilm { get; set; }
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
