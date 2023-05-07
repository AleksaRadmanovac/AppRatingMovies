using Domen;
using Domen.Communication;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Forme
{
    public class Communication
    {
        private Socket socket;
        private SlanjePrijem slanje;
        private SlanjePrijem prijem;
        private static Communication instance;

        public static Communication Instance 
        {
            get 
            {
                if (instance == null)
                { 
                    instance = new Communication();
                }
                return instance;
            }
        }
        private Communication() { }

        public void Connect() 
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);
                slanje = new SlanjePrijem(socket);
                prijem = new SlanjePrijem(socket);
            }
            catch (SocketException)
            {
                MainCoordinator.Instance.ServerskaGreska();
            }
        }

        public LoginOdgovor Login(LoginZahtev loginZahtev)
        {
            try
            {
                slanje.Slanje(new Zahtev() { Objekat = loginZahtev, Operacija = Operacija.Login });


                Odgovor odgovor = prijem.Prijem<Odgovor>();
                if (odgovor.Exception == null)
                {
                    return (LoginOdgovor)odgovor.Objekat;
                }
                else { throw odgovor.Exception; }
            }
            catch (IOException ex) { throw ex; }
        }

        public bool Registracija(object objekat)
        {
            slanje.Slanje(new Zahtev() { Objekat = objekat, Operacija = Operacija.Registracija });
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
                return true;
            }
            else 
            {
                throw odgovor.Exception;
            }
        }

        public List<Film> PretraziFilmove(string kriterijum)
        { 
            List<Film> lista = new List<Film>();
            Zahtev zahtev = new Zahtev();
            zahtev.Objekat = kriterijum;
            zahtev.Operacija = Operacija.PronadjiFilmove;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
                foreach (Film f in (List<Film>)odgovor.Objekat)
                {
                    if (!lista.Contains(f))
                    {
                        lista.Add(f);
                    }
                }
                return lista;
            }
            else { throw odgovor.Exception; }
        }

        public List<Glumac> PretraziGlumce(string kriterijum)
        {
            List<Glumac> lista = new List<Glumac>();
            Zahtev zahtev = new Zahtev();
            zahtev.Objekat = kriterijum;
            zahtev.Operacija = Operacija.PronadjiGlumce;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
                foreach(Glumac g in (List<Glumac>)odgovor.Objekat)
                {
                    if (!lista.Contains(g)) lista.Add(g);
                }
                return lista;
            }
            else { throw odgovor.Exception; }
        }

        public List<Film> UcitajListuFilmova()
        {
            List<Film> lista = new List<Film>();
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.UcitajListuFilmova;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
                return (List<Film>)odgovor.Objekat;
            }
            else { throw odgovor.Exception; }
        }

        public List<Glumac> UcitajListuGlumaca()
        {
            List<Glumac> lista = new List<Glumac>();
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.UcitajListuGlumaca;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
                return (List<Glumac>)odgovor.Objekat;
            }
            else { throw odgovor.Exception; }
        }

        public int PodnesiZahtevZaFilm(ZahtevZaFilm zahtevZaFilm)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Objekat = zahtevZaFilm;
            zahtev.Operacija = Operacija.SacuvajZahtev;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
                return (int)odgovor.Objekat;
            }
            else
            {
                throw odgovor.Exception;
            }
        }

        public void DodajUlogu(Uloga uloga)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Objekat = uloga;
            zahtev.Operacija = Operacija.DodajUlogu;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {

            }
            else
            {
                throw odgovor.Exception;
            }
        }

        public List<Uloga> UcitajListuUlogaZaFilm(int filmId)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Objekat = filmId;
            zahtev.Operacija = Operacija.UcitajListuUlogaZaFilm;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
                return (List<Uloga>)odgovor.Objekat;
            }
            else
            {
                throw odgovor.Exception;
            }
        }

        public void SacuvajOcene(OcenaFilma of, List<OcenaUloge> listaOU)
        { 
            OceneZahtev ocenaZahtev = new OceneZahtev();
            ocenaZahtev.OcenaFilma = of;
            ocenaZahtev.ListaOcenaUloga = listaOU;
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.SacuvajOcene;
            zahtev.Objekat = ocenaZahtev;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
            }
            else 
            {
                throw odgovor.Exception;
            }
        }

        public void SacuvajOcenuGlumca(OcenaGlumca og)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.SacuvajOcenuGlumca;
            zahtev.Objekat = og;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
            }
            else
            {
                throw odgovor.Exception;
            }
        }

        public void PodnesiZahtevZaGlumca(ZahtevZaGlumca zahtevZaGlumca)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.SacuvajZahtevZaGlumca;
            zahtev.Objekat = zahtevZaGlumca;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            { }
            else
            {
                throw odgovor.Exception;
            }
        }

        public List<Film> PronadjiFilmovePoGlumcu(int glumacID)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.PronadjiFilmovePoGlumcu;
            zahtev.Objekat = glumacID;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
                return (List<Film>)odgovor.Objekat;
            }
            else
            {
                throw odgovor.Exception;
            }
        }

        public List<ZahtevZaFilm> UcitajListuZahteva()
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.UcitajListuZahteva;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
                return (List<ZahtevZaFilm>)odgovor.Objekat;
            }
            else
            {
                throw odgovor.Exception;
            }
        }

        public List<ZahtevZaGlumca> UcitajListuZahtevaZaGlumca()
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.UcitajListuZahtevaZaGlumca;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
                return (List<ZahtevZaGlumca>)odgovor.Objekat;
            }
            else
            {
                throw odgovor.Exception;
            }
        }

        public void SacuvajOdluku(ZahtevZaFilm zf, bool p=false)
        {
            Zahtev zahtev = new Zahtev();
            CuvanjeOdlukeZahtev cozahtev = new CuvanjeOdlukeZahtev();
            cozahtev.Objekat = zf;
            cozahtev.DodavanjeUloga = p;
            zahtev.Operacija = Operacija.CuvanjeOdluke;
            zahtev.Objekat = cozahtev;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
            }
            else
            {
                throw odgovor.Exception;
            }
        }

        public void SacuvajOdlukuZaGlumca(ZahtevZaGlumca zg)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.CuvanjeOdlukeZaGlumca;
            zahtev.Objekat = zg;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
            }
            else
            {
                throw odgovor.Exception;
            }
        }

        public VratiOceneOdgovor VratiOceneFilma(OcenaFilma of)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiOceneFilma;
            zahtev.Objekat = of;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
                return (VratiOceneOdgovor)odgovor.Objekat;
            }
            else
            {
                throw odgovor.Exception;
            }
        }

        public void PromeniOcene(OcenaFilma of, List<OcenaUloge> listaOU)
        {
            OceneZahtev ocenaZahtev = new OceneZahtev();
            ocenaZahtev.OcenaFilma = of;
            ocenaZahtev.ListaOcenaUloga = listaOU;
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.PromeniOcene;
            zahtev.Objekat = ocenaZahtev;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
            }
            else
            {
                throw odgovor.Exception;
            }
        }

        public OcenaGlumca VratiOcenuGlumca(OcenaGlumca og)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiOcenuGlumca;
            zahtev.Objekat = og;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
                return (OcenaGlumca)odgovor.Objekat;
            }
            else 
            {
                throw odgovor.Exception;
            }
        }
        public void PromeniOcenuGlumca(OcenaGlumca og)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.PromeniOcenuGlumca;
            zahtev.Objekat = og;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
            }
            else
            {
                throw odgovor.Exception;
            }
        }

        public Film VratiSveOceneZaFilm(Film film)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiSveOceneZaFilm;
            zahtev.Objekat = film;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
                return (Film)odgovor.Objekat;
            }
            else
            {
                throw odgovor.Exception;
            }
        }

        public Glumac VratiSveOceneZaGlumca(Glumac glumac)
        {
            Zahtev zahtev = new Zahtev();
            zahtev.Operacija = Operacija.VratiSveOceneZaGlumca;
            zahtev.Objekat = glumac;
            slanje.Slanje(zahtev);
            Odgovor odgovor = prijem.Prijem<Odgovor>();
            if (odgovor.Exception == null)
            {
                return (Glumac)odgovor.Objekat;
            }
            else
            {
                throw odgovor.Exception;
            }
        }


    }
}
