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
    internal class OcenaGlumcaTest
    {
        OcenaGlumca a;
        public IDbRepository<IDomenObjekat> repository;
        [SetUp] public void SetUp() { a = new OcenaGlumca(); DbBroker.DbConnection.test = true; }

        [TearDown] public void TearDown() { a = null; DbBroker.DbConnection.test = false; }

        [Test]
        public void TestGetObj()
        {
            Korisnik k = new Korisnik();
            Glumac g = new Glumac();
            k.Id = 1;
            k.Username = "KorisnikTest";
            k.Password = "KorisnikTest";
            k.Pol = (Pol)1;
            g.Id = 1;
            g.Ime = "Imetest";
            g.Prezime = "Prezimetest";
            g.Godiste = 2000;
            g.Pol = (Pol)1;
            g.Prikazan = true;
            a.Glumac = g;
            a.Korisnik = k;
            a.Ocena = 5;
            a.Komentar = "";



            repository = new GenericRepository();
            OcenaGlumca rez = (OcenaGlumca)repository.Get(a);

            Assert.NotNull(rez);
            Assert.NotNull(rez.Glumac);
            Assert.NotNull(rez.Korisnik);
            Assert.AreEqual(a.Korisnik.Id, rez.Korisnik.Id);
            Assert.AreEqual(a.Korisnik.Username, rez.Korisnik.Username);
            Assert.AreEqual(a.Korisnik.Password, rez.Korisnik.Password);
            Assert.AreEqual(a.Korisnik.Pol, rez.Korisnik.Pol);
            Assert.AreEqual(a.Glumac.Id, rez.Glumac.Id);
            Assert.AreEqual(a.Glumac.Ime, rez.Glumac.Ime);
            Assert.AreEqual(a.Glumac.Prezime, rez.Glumac.Prezime);
            Assert.AreEqual(a.Glumac.Godiste, rez.Glumac.Godiste);
            Assert.AreEqual(a.Glumac.Pol, rez.Glumac.Pol);
            Assert.AreEqual(a.Glumac.Prikazan, rez.Glumac.Prikazan);
            Assert.AreEqual(a.Ocena, rez.Ocena);
            Assert.AreEqual(a.Komentar, rez.Komentar);
        }
    }
}
