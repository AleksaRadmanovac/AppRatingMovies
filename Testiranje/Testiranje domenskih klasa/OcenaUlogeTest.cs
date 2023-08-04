using DbBroker;
using Domen;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testiranje
{
    internal class OcenaUlogeTest
    {
        OcenaUloge a;
        public IDbRepository<IDomenObjekat> repository;
        [SetUp] public void SetUp() { a = new OcenaUloge(); DbBroker.DbConnection.test = true; repository = new GenericRepository(); }

        [TearDown] public void TearDown() { a = null; DbBroker.DbConnection.test = false; repository.Close(); }

        [Test]
        public void TestGetObj()
        {
            a.Korisnik = new Korisnik();
            a.Uloga = new Uloga();
            a.Korisnik.Id = 1;
            a.Korisnik.Username = "KorisnikTest";
            a.Korisnik.Password = "KorisnikTest";
            a.Korisnik.Pol = (Pol)1;
            a.Uloga.Ime = "Imetest";
            a.Uloga.JeGlavna = true;
            a.Uloga.Film = new Film();
            a.Uloga.Film.Id = (int)1;
            a.Uloga.Film.Naziv = "FilmTest";
            a.Uloga.Film.Zanr = (Zanr)2;
            a.Uloga.Film.Prikazan = true;
            a.Uloga.Glumac = new Glumac();
            a.Uloga.Glumac.Id = (int)1;
            a.Uloga.Glumac.Ime = "Imetest";
            a.Uloga.Glumac.Prezime = "Prezimetest";
            a.Uloga.Glumac.Godiste = 2000;
            a.Uloga.Glumac.Pol = (Pol)1;
            a.Uloga.Glumac.Prikazan = true;
            a.Ocena = 5;
            a.Komentar = "";



            
            OcenaUloge rez = (OcenaUloge)repository.Get(a);

            Assert.NotNull(rez);
            Assert.NotNull(rez.Korisnik);
            Assert.NotNull(rez.Uloga);
            Assert.NotNull(rez.Uloga.Glumac);
            Assert.NotNull(rez.Uloga.Film);
            Assert.AreEqual(a.Korisnik.Id, rez.Korisnik.Id);
            Assert.AreEqual(a.Korisnik.Username, rez.Korisnik.Username);
            Assert.AreEqual(a.Korisnik.Password, rez.Korisnik.Password);
            Assert.AreEqual(a.Korisnik.Pol, rez.Korisnik.Pol);
            Assert.AreEqual(a.Uloga.Ime, rez.Uloga.Ime);
            Assert.AreEqual(a.Uloga.JeGlavna, rez.Uloga.JeGlavna);
            Assert.AreEqual(a.Uloga.Film.Id, rez.Uloga.Film.Id);
            Assert.AreEqual(a.Uloga.Film.Naziv, rez.Uloga.Film.Naziv);
            Assert.AreEqual(a.Uloga.Film.Zanr, rez.Uloga.Film.Zanr);
            Assert.AreEqual(a.Uloga.Film.Prikazan, rez.Uloga.Film.Prikazan);
            Assert.AreEqual(a.Uloga.Glumac.Id, rez.Uloga.Glumac.Id);
            Assert.AreEqual(a.Uloga.Glumac.Ime, rez.Uloga.Glumac.Ime);
            Assert.AreEqual(a.Uloga.Glumac.Prezime, rez.Uloga.Glumac.Prezime);
            Assert.AreEqual(a.Uloga.Glumac.Godiste, rez.Uloga.Glumac.Godiste);
            Assert.AreEqual(a.Uloga.Glumac.Pol, rez.Uloga.Glumac.Pol);
            Assert.AreEqual(a.Uloga.Glumac.Prikazan, rez.Uloga.Glumac.Prikazan);
            Assert.AreEqual(a.Ocena, rez.Ocena);
            Assert.AreEqual(a.Komentar, rez.Komentar);
        }
    }
}
