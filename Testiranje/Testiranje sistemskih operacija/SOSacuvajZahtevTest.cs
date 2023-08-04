using DbBroker;
using Domen;
using NUnit.Framework;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testiranje.Testiranje_sistemskih_operacija
{
    internal class SOSacuvajZahtevTest
    {
        public IDbRepository<IDomenObjekat> repository;
        [SetUp]
        public void SetUp()
        {
            repository = new GenericRepository();
            DbBroker.DbConnection.test = true;
        }

        [TearDown]
        public void TearDown()
        {
            repository.Rollback();
            repository.Close();
            DbBroker.DbConnection.test = false;
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju()
        {
            SOSacuvajZahtev so = new SOSacuvajZahtev();
            Film film = new Film() { Naziv = "Imetest5", Zanr = (Zanr)1, Prikazan = false };
            ZahtevZaFilm zahtevZaFilm = new ZahtevZaFilm() { Odobren = false, Obradjen = false, Film = film, Administrator = null };
            List<Uloga> listaUloga = new List<Uloga>()
            {
                new Uloga {
                    Film = new Film() { Naziv = "Imetest5", Zanr = (Zanr)1, Prikazan = false},
                    Glumac = new Glumac() { Id = 1, Ime = "Imetest", Prezime = "Prezimetest", Godiste = 2000, Pol = (Pol)1, Prikazan = true },
                    Ime = "Imetest6",
                    JeGlavna = true
                },
                new Uloga {
                    Film = new Film() { Naziv = "Imetest5", Zanr = (Zanr)1, Prikazan = false},
                    Glumac = new Glumac() { Id = 4, Ime = "Imetest3", Prezime = "Prezimetest3", Godiste = 1999, Pol = (Pol)1, Prikazan = true },
                    Ime = "Imetest7",
                    JeGlavna = false
                }
            };
            zahtevZaFilm.Uloge = listaUloga;
            so.Zahtev = zahtevZaFilm;
            List<IDomenObjekat> listaZahteva = repository.GetAll(new ZahtevZaFilm());
            so.IzvrsiSistemskuOperaciju();
            zahtevZaFilm.Film.Id = so.FilmId;
            ZahtevZaFilm rezZahtev = (ZahtevZaFilm)repository.Get(zahtevZaFilm);

            List<IDomenObjekat> rez = repository.GetAll(new ZahtevZaFilm());

            Film rezFilm = (Film)repository.Get(zahtevZaFilm.Film);

            List<Uloga> rezListaUloga = new List<Uloga>();
            foreach (Uloga uloga in listaUloga)
            {
                uloga.Film.Id = so.FilmId;
                rezListaUloga.Add((Uloga)repository.Get(uloga));
            }

            Assert.Greater(rez.Count, listaZahteva.Count);

            Assert.NotNull(rezFilm);
            Assert.AreEqual(rezFilm.Naziv, film.Naziv);
            Assert.AreEqual(rezFilm.Zanr, film.Zanr);
            Assert.AreEqual(rezFilm.Prikazan, film.Prikazan);

            for (int i = 0; i < listaUloga.Count; i++)
            {
                Assert.NotNull(rezListaUloga[i]);
                Assert.NotNull(rezListaUloga[i].Film);
                Assert.NotNull(rezListaUloga[i].Glumac);
                Assert.AreEqual(rezListaUloga[i].Film.Id, listaUloga[i].Film.Id);
                Assert.AreEqual(rezListaUloga[i].Glumac.Id, listaUloga[i].Glumac.Id);
                Assert.AreEqual(rezListaUloga[i].Ime, listaUloga[i].Ime);
                Assert.AreEqual(rezListaUloga[i].JeGlavna, listaUloga[i].JeGlavna);
            }

        }
    }
}
