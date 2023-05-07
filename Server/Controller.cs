using Domen;
using Domen.Communication;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Controller
    {

        private static Controller instance;

        public static Controller Instance 
        {
            get 
            {
                if (instance == null)
                {
                   instance = new Controller();
                }
                return instance;
            }  
        }

        private Controller() { }

        public List<Film> UcitajListuFilmova()
        {
            OsnovaSistemskihOperacija so = new SOUcitajListuFilmova();
            so.Izvrsi();
            return ((SOUcitajListuFilmova)so).UcitanaLista;
        }

        public LoginOdgovor Login(LoginZahtev loginZahtev)
        {
            OsnovaSistemskihOperacija so = new SOLogin();
            ((SOLogin)so).loginZahtev = loginZahtev;
            so.Izvrsi();
            return new LoginOdgovor() { Nalog = ((SOLogin)so).Nalog, Uspesan = ((SOLogin)so).Uspesan };
        }

        public List<Glumac> UcitajListuGlumaca()
        {
            OsnovaSistemskihOperacija so = new SOUcitajListuGlumaca();
            so.Izvrsi();
            return ((SOUcitajListuGlumaca)so).UcitanaLista;
        }

        public Film PrikaziFilm(int filmID)
        {
            OsnovaSistemskihOperacija so = new SOPrikaziFilm();
            ((SOPrikaziFilm)so).FilmID = filmID;
            return ((SOPrikaziFilm)so).Rez;
        }

        public Glumac PrikaziGlumca(int GlumacID)
        {
            OsnovaSistemskihOperacija so = new SOPrikaziGlumca();
            ((SOPrikaziGlumca)so).GlumacID = GlumacID;
            return ((SOPrikaziGlumca)so).Rez;
        }

        public void SacuvajOcene(OceneZahtev oceneZahtev) 
        {
            SOSacuvajOcene so = new SOSacuvajOcene();
            so.OcenaFilma = oceneZahtev.OcenaFilma;
            so.ListaOcenaUloga = oceneZahtev.ListaOcenaUloga;
            so.Izvrsi();
        }

        public void SacuvajOcenuGlumca(OcenaGlumca ocenaGlumca) 
        {
            SOSacuvajOcenuGlumca so = new SOSacuvajOcenuGlumca();
            so.OcenaGlumca = ocenaGlumca;
            so.Izvrsi();
        }

        public List<Film> PronadjiFilmove(string kriterijum)
        {
            SOPronadjiFilmove so = new SOPronadjiFilmove();
            so.Kriterijum = kriterijum;
            so.Izvrsi();
            return so.ListaFilmova;
        }

        public List<Glumac> PronadjiGlumce(string kriterijum)
        {
            SOPronadjiGlumce so = new SOPronadjiGlumce();
            so.Kriterijum = kriterijum;
            so.Izvrsi();
            return so.ListaGlumaca;
        }

        public int SacuvajZahtev(ZahtevZaFilm zahtev)
        {
            SOSacuvajZahtev so = new SOSacuvajZahtev();
            so.Zahtev = zahtev;
            so.Izvrsi();
            return so.FilmId;
        }

        public void SacuvajZahtevZaGlumca(ZahtevZaGlumca zahtev)
        {
            SOSacuvajZahtevZaGlumca so = new SOSacuvajZahtevZaGlumca();
            so.Zahtev = zahtev;
            so.Izvrsi();
        }

        public List<ZahtevZaFilm> UcitajListuZahteva()
        {
            SOUcitajListuZahteva so = new SOUcitajListuZahteva();
            so.Izvrsi();
            return so.ListaZahteva;
        }

        public List<ZahtevZaGlumca> UcitajListuZahtevaZaGlumca()
        {
            SOUcitajListuZahtevaZaGlumca so = new SOUcitajListuZahtevaZaGlumca();
            so.Izvrsi();
            return so.ListaZahtevaZaGlumca;
        }

        public ZahtevZaFilm UcitavanjeZahteva(int ID)
        {
            SOUcitavanjeZahteva so = new SOUcitavanjeZahteva();
            so.Id = ID;
            so.Izvrsi();
            return so.ZahtevZaFilm;
        }

        public ZahtevZaGlumca UcitavanjeZahtevaZaGlumca(int ID)
        {
            SOUcitavanjeZahtevaZaGlumca so = new SOUcitavanjeZahtevaZaGlumca();
            so.Id = ID;
            so.Izvrsi();
            return so.ZahtevZaGlumca;
        }

        public void CuvanjeOdluke(ZahtevZaFilm zahtevZaFilm, bool p)
        {
            SOCuvanjeOdluke so = new SOCuvanjeOdluke();
            so.ZahtevZaFilm = zahtevZaFilm;
            so.DodavanjeUloga = p;
            so.Izvrsi();
        }

        public void CuvanjeOdlukeZaGlumca(ZahtevZaGlumca zg)
        {
            SOCuvanjeOdlukeZaGlumca so = new SOCuvanjeOdlukeZaGlumca();
            so.ZahtevZaGlumca = zg;
            so.Izvrsi();
        }

        public List<Uloga> UcitajListuUlogaZaFilm(int ID)
        { 
            SOUcitajListuUlogaZaFilm so = new SOUcitajListuUlogaZaFilm();
            so.FilmID = ID;
            so.Izvrsi();
            return so.ListaUloga;
        }

        public void Registracija(Korisnik korisnik)
        {
            SORegistracija so = new SORegistracija();
            so.Korisnik = korisnik;
            so.Izvrsi();
        }

        public void DodajUlogu(Uloga uloga)
        {
            SODodajUlogu so = new SODodajUlogu();
            so.Uloga = uloga;
            so.Izvrsi();
        }

        public List<Film> PronadjiFilmovePoGlumcu(int glumacID)
        {
            SOPronadjiFilmovePoGlumcu so = new SOPronadjiFilmovePoGlumcu();
            so.GlumacID = glumacID;
            so.Izvrsi();
            return so.ListaFilmova;
        }

        public VratiOceneOdgovor VratiOceneFilma(OcenaFilma ocenaFilma)
        {
            SOVratiOceneFilma so = new SOVratiOceneFilma();
            so.OcenaFilma = ocenaFilma;
            so.Izvrsi();
            return so.Odgovor;
        }

        public void PromeniOcene(OceneZahtev oceneZahtev)
        {
            SOPromeniOcene so = new SOPromeniOcene();
            so.OcenaFilma = oceneZahtev.OcenaFilma;
            so.ListaOcenaUloga = oceneZahtev.ListaOcenaUloga;
            so.Izvrsi();
        }

        public OcenaGlumca VratiOcenuGlumca(OcenaGlumca og)
        { 
            SOVratiOcenuGlumca so = new SOVratiOcenuGlumca();
            so.OcenaGlumca = og;
            so.Izvrsi();
            return so.OcenaGlumca;
        }

        public void PromeniOcenuGlumca(OcenaGlumca og)
        {
            SOPromeniOcenuGlumca so = new SOPromeniOcenuGlumca();
            so.OcenaGlumca = og;
            so.Izvrsi();
            
        }

        public Film VratiSveOceneZaFilm(Film film)
        {
            SOVratiSveOceneZaFilm so = new SOVratiSveOceneZaFilm();
            so.Film = film;
            so.Izvrsi();
            return so.Film;
        }

        public Glumac VratiSveOceneZaGlumca(Glumac glumac)
        {
            SOVratiSveOceneZaGlumca so = new SOVratiSveOceneZaGlumca();
            so.Glumac = glumac;
            so.Izvrsi();
            return so.Glumac;
        }

    }
}
