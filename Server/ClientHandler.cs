using Domen;
using Domen.Communication;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Socket socket;
        private SlanjePrijem prijem;
        private SlanjePrijem slanje;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            prijem = new SlanjePrijem(socket);
            slanje = new SlanjePrijem(socket);
        }

        public void ObradiZahtev()
        {
            try
            {
                while (socket.Connected)
                {

                    Zahtev z = prijem.Prijem<Zahtev>();
                    Odgovor odg = new Odgovor();
                    try
                    {
                        switch (z.Operacija)
                        {
                            case Operacija.UcitajListuFilmova:
                                odg.Objekat = Controller.Instance.UcitajListuFilmova();
                                break;
                            case Operacija.Login:
                                LoginZahtev loginZahtev = (LoginZahtev)z.Objekat;
                                odg.Objekat = Controller.Instance.Login(loginZahtev);
                                break;
                            case Operacija.UcitajListuGlumaca:
                                odg.Objekat = Controller.Instance.UcitajListuGlumaca();
                                break;
                            case Operacija.PrikaziFilm:
                                int filmID = (int)z.Objekat;
                                odg.Objekat = Controller.Instance.PrikaziFilm(filmID);
                                break;
                            case Operacija.PrikaziGlumca:
                                int glumacID = (int)z.Objekat;
                                odg.Objekat = Controller.Instance.PrikaziGlumca(glumacID);
                                break;
                            case Operacija.SacuvajOcene:
                                OceneZahtev oceneZahtev = (OceneZahtev)z.Objekat;
                                Controller.Instance.SacuvajOcene(oceneZahtev);
                                break;
                            case Operacija.SacuvajOcenuGlumca:
                                Controller.Instance.SacuvajOcenuGlumca((OcenaGlumca)z.Objekat);
                                break;
                            case Operacija.PronadjiFilmove:
                                odg.Objekat = Controller.Instance.PronadjiFilmove((string)z.Objekat);
                                break;
                            case Operacija.PronadjiGlumce:
                                odg.Objekat = Controller.Instance.PronadjiGlumce((string)z.Objekat);
                                break;
                            case Operacija.SacuvajZahtev:
                                odg.Objekat = Controller.Instance.SacuvajZahtev((ZahtevZaFilm)z.Objekat);
                                break;
                            case Operacija.SacuvajZahtevZaGlumca:
                                Controller.Instance.SacuvajZahtevZaGlumca((ZahtevZaGlumca)z.Objekat);
                                break;
                            case Operacija.UcitajListuZahteva:
                                odg.Objekat = Controller.Instance.UcitajListuZahteva();
                                break;
                            case Operacija.UcitajListuZahtevaZaGlumca:
                                odg.Objekat = Controller.Instance.UcitajListuZahtevaZaGlumca();
                                break;
                            case Operacija.UcitavanjeZahteva:
                                odg.Objekat = Controller.Instance.UcitavanjeZahteva((int)z.Objekat);
                                break;
                            case Operacija.UcitavanjeZahtevaZaGlumca:
                                odg.Objekat = Controller.Instance.UcitavanjeZahtevaZaGlumca((int)z.Objekat);
                                break;
                            case Operacija.CuvanjeOdluke:
                                CuvanjeOdlukeZahtev cou = (CuvanjeOdlukeZahtev)z.Objekat;
                                ZahtevZaFilm zf = (ZahtevZaFilm)cou.Objekat;
                                Controller.Instance.CuvanjeOdluke(zf, cou.DodavanjeUloga);
                                break;
                            case Operacija.CuvanjeOdlukeZaGlumca:
                                ZahtevZaGlumca zg = (ZahtevZaGlumca)z.Objekat;
                                Controller.Instance.CuvanjeOdlukeZaGlumca(zg);
                                break;
                            case Operacija.UcitajListuUlogaZaFilm:
                                odg.Objekat = Controller.Instance.UcitajListuUlogaZaFilm((int)z.Objekat);
                                break;
                            case Operacija.Registracija:
                                Controller.Instance.Registracija((Korisnik)z.Objekat);
                                break;
                            case Operacija.DodajUlogu:
                                Controller.Instance.DodajUlogu((Uloga)z.Objekat);
                                break;
                            case Operacija.PronadjiFilmovePoGlumcu:
                                odg.Objekat = Controller.Instance.PronadjiFilmovePoGlumcu((int)z.Objekat);
                                break;
                            case Operacija.VratiOceneFilma:
                                odg.Objekat = Controller.Instance.VratiOceneFilma((OcenaFilma)z.Objekat);
                                break;
                            case Operacija.PromeniOcene:
                                OceneZahtev ocenePromena = (OceneZahtev)z.Objekat;
                                Controller.Instance.PromeniOcene(ocenePromena);
                                break;
                            case Operacija.VratiOcenuGlumca:
                                odg.Objekat = Controller.Instance.VratiOcenuGlumca((OcenaGlumca)z.Objekat);
                                break;
                            case Operacija.PromeniOcenuGlumca:
                                Controller.Instance.PromeniOcenuGlumca((OcenaGlumca)z.Objekat);
                                break;
                            case Operacija.VratiSveOceneZaFilm:
                                odg.Objekat = Controller.Instance.VratiSveOceneZaFilm((Film)z.Objekat);
                                break;
                            case Operacija.VratiSveOceneZaGlumca:
                                odg.Objekat = Controller.Instance.VratiSveOceneZaGlumca((Glumac)z.Objekat);
                                break;
                        }

                    }
                    catch (Exception ex)
                    {
                        odg.Exception = ex;
                    }
                    finally
                    {
                        slanje.Slanje(odg);
                    }

                }
            }
            catch (IOException)
            { 
            
            }
            

        }



    }
}
