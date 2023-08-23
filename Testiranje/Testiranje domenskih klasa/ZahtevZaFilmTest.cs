using DbBroker;
using Domen;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Testiranje
{
    internal class ZahtevZaFilmTest
    {
        ZahtevZaFilm a;
        [SetUp] public void SetUp() { a = new ZahtevZaFilm(); }

        [TearDown] public void TearDown() { a = null; }

        [Test]
        public void TestGetObjNeobradjen()
        {
            a.Id = 2;
            a.Odobren = false;
            a.Obradjen = false;
            a.Film = new Film();
            a.Film.Id = 2;
            a.Film.Naziv = "FilmTest2";
            a.Film.Zanr = (Zanr)3;
            a.Film.Prikazan = false;
            a.Administrator = new Administrator();

            
            ZahtevZaFilm rez = (ZahtevZaFilm)TestSetup.repository.Get(a);

            Assert.IsNotNull(rez);
            Assert.IsNotNull(rez.Film);
            Assert.AreEqual(a.Id, rez.Id);
            Assert.AreEqual(a.Obradjen, rez.Obradjen);
            Assert.AreEqual(a.Odobren, rez.Odobren);
            Assert.AreEqual(a.Film.Id, rez.Film.Id);
            Assert.AreEqual(a.Film.Naziv,rez.Film.Naziv);
            Assert.AreEqual(a.Film.Zanr, rez.Film.Zanr);
            Assert.AreEqual(a.Film.Prikazan, rez.Film.Prikazan);

        }

        [Test]
        public void TestGetObjObradjen()
        {
            a.Id = 4;
            a.Odobren = true;
            a.Obradjen = true;
            a.Administrator = new Administrator();
            a.Administrator.Id = 1;
            a.Administrator.Username = "AdminTest";
            a.Administrator.Password = "AdminTest";
            a.Administrator.BrojObradjenihZahteva = 5;

            a.Film = new Film();
            a.Film.Id = 1;
            a.Film.Naziv = "FilmTest";
            a.Film.Zanr = (Zanr)2;
            a.Film.Prikazan = true;

            ZahtevZaFilm rez = (ZahtevZaFilm)TestSetup.repository.Get(a);

            Assert.NotNull(rez);
            Assert.NotNull(rez.Film);
            Assert.NotNull(rez.Administrator);
            Assert.AreEqual(a.Id, rez.Id);
            Assert.AreEqual(a.Odobren, rez.Odobren);
            Assert.AreEqual(a.Obradjen, rez.Obradjen);
            Assert.AreEqual(a.Administrator.Id, rez.Administrator.Id);
            Assert.AreEqual(a.Administrator.Username, rez.Administrator.Username);
            Assert.AreEqual(a.Administrator.Password, rez.Administrator.Password);
            Assert.AreEqual(a.Administrator.BrojObradjenihZahteva, rez.Administrator.BrojObradjenihZahteva);
            Assert.AreEqual(a.Film.Id, rez.Film.Id);
            Assert.AreEqual(a.Film.Naziv, rez.Film.Naziv);
            Assert.AreEqual(a.Film.Zanr, rez.Film.Zanr);
            Assert.AreEqual(a.Film.Prikazan, rez.Film.Prikazan);
        }
    }
}
