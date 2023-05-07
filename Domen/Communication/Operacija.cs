using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Communication
{
    public enum Operacija
    {
        UcitajListuFilmova,
        Login,
        UcitajListuGlumaca,
        PrikaziFilm,
        SacuvajOcene,
        PrikaziGlumca,
        SacuvajOcenuGlumca,
        PronadjiFilmove,
        PronadjiGlumce,
        SacuvajZahtev,
        SacuvajZahtevZaGlumca,
        UcitajListuZahteva,
        UcitavanjeZahteva,
        CuvanjeOdluke,
        UcitajListuZahtevaZaGlumca,
        UcitavanjeZahtevaZaGlumca,
        CuvanjeOdlukeZaGlumca,
        UcitajListuUlogaZaFilm,
        Registracija,
        DodajUlogu,
        PronadjiFilmovePoGlumcu,
        VratiOceneFilma,
        PromeniOcene,
        VratiOcenuGlumca,
        PromeniOcenuGlumca,
        VratiSveOceneZaFilm,
        VratiSveOceneZaGlumca
    }
}
