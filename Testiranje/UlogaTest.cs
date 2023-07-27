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
    internal class UlogaTest
    {
        Uloga a;
        public IDbRepository<IDomenObjekat> repository;
        [SetUp] public void SetUp() { a = new Uloga(); DbBroker.DbConnection.test = true; }

        [TearDown] public void TearDown() { a = null; DbBroker.DbConnection.test = false; }

        [Test]
        public void TestGetObj()
        {
            a.Ime = "Imetest";
            a.JeGlavna = true;
            a.Film = new Film();
            a.Film.Id = 1;
            a.Film.Naziv = "FilmTest";
            a.Film.Zanr = (Zanr)2;
            a.Film.Prikazan = true;
            a.Glumac = new Glumac();
            a.Glumac.Id = (int)1;
            a.Glumac.Ime = "Imetest";
            a.Glumac.Prezime = "Prezimetest";
            a.Glumac.Godiste = 2000;
            a.Glumac.Pol = (Pol)1;
            a.Glumac.Prikazan = true;



            repository = new GenericRepository();
            Uloga rez = (Uloga)repository.Get(a);
                
            Assert.NotNull(rez);
            Assert.NotNull(rez.Glumac);
            Assert.NotNull(rez.Film);
            Assert.AreEqual(a.Ime, rez.Ime);
            Assert.AreEqual(a.JeGlavna, rez.JeGlavna);
            Assert.AreEqual(a.Film.Id, rez.Film.Id);
            Assert.AreEqual(a.Film.Naziv, rez.Film.Naziv);
            Assert.AreEqual(a.Film.Zanr, rez.Film.Zanr);
            Assert.AreEqual(a.Film.Prikazan, rez.Film.Prikazan);
            Assert.AreEqual(a.Glumac.Id, rez.Glumac.Id);
            Assert.AreEqual(a.Glumac.Ime, rez.Glumac.Ime);
            Assert.AreEqual(a.Glumac.Prezime, rez.Glumac.Prezime);
            Assert.AreEqual(a.Glumac.Godiste, rez.Glumac.Godiste);
            Assert.AreEqual(a.Glumac.Pol, rez.Glumac.Pol);
            Assert.AreEqual(a.Glumac.Prikazan, rez.Glumac.Prikazan);

        }
        }
}
