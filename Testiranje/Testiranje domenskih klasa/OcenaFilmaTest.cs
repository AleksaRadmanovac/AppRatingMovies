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
    internal class OcenaFilmaTest
    {
        OcenaFilma a;
        public IDbRepository<IDomenObjekat> repository;
        [SetUp] public void SetUp() { a = new OcenaFilma(); DbBroker.DbConnection.test = true; }

        [TearDown] public void TearDown() { a = null; DbBroker.DbConnection.test = false; }

        [Test]
        public void TestGetObj()
        {
            Korisnik k = new Korisnik();
            Film f = new Film();
            k.Id = 1;
            k.Username = "KorisnikTest";
            k.Password = "KorisnikTest";
            k.Pol = (Pol)1;
            f.Id = 1;
            f.Naziv = "FilmTest";
            f.Prikazan = true;
            f.Zanr = (Zanr)2;
            a.Film = f;
            a.Korisnik = k;
            a.Ocena = 5;
            a.Komentar = "";



            repository = new GenericRepository();
            OcenaFilma rez = (OcenaFilma)repository.Get(a);

            Assert.NotNull(rez);
            Assert.NotNull(rez.Film);
            Assert.NotNull(rez.Korisnik);
            Assert.AreEqual(a.Korisnik.Id, rez.Korisnik.Id);
            Assert.AreEqual(a.Korisnik.Username, rez.Korisnik.Username);
            Assert.AreEqual(a.Korisnik.Password, rez.Korisnik.Password);
            Assert.AreEqual(a.Korisnik.Pol, rez.Korisnik.Pol);
            Assert.AreEqual(a.Film.Id, rez.Film.Id);
            Assert.AreEqual(a.Film.Naziv, rez.Film.Naziv);
            Assert.AreEqual(a.Film.Zanr, rez.Film.Zanr);
            Assert.AreEqual(a.Film.Prikazan, rez.Film.Prikazan);
            Assert.AreEqual(a.Ocena, rez.Ocena);
            Assert.AreEqual(a.Komentar, rez.Komentar);
        }
    }   
}
