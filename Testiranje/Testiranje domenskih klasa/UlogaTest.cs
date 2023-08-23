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
        [SetUp] public void SetUp() { a = new Uloga(); }

        [TearDown] public void TearDown() { a = null; }

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
            Uloga rez = (Uloga)TestSetup.repository.Get(a);
                
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

        [Test]
        [TestCase("Aleksa", "Radmanovac", "Driver", true)]
        [TestCase("Aleksa", "Radmanovac", "Driver", false)]
        public void TestToString(string imeG, string prezimeG, string ime, bool jeGlavna )
        {
            a.Glumac = new Glumac();
            a.Glumac.Ime = imeG;
            a.Glumac.Prezime = prezimeG;
            a.Ime = ime;
            a.JeGlavna = jeGlavna;

            string rez = a.ToString();

            Assert.IsTrue(rez.Contains("Aleksa"));
            Assert.IsTrue(rez.Contains("Radmanovac"));
            Assert.IsTrue(rez.Contains("Driver"));
            if (jeGlavna)
                Assert.IsTrue(rez.Contains("glavna"));
            else Assert.IsFalse(rez.Contains("glava"));
        }

        [Test]
        [TestCaseSource(nameof(GetTestObjects))]
        public void TestEquals(PomocnaTestKlasa obj)
        {
            Glumac glumac1 = new Glumac { Id = 1 };
            Film film1 = new Film { Id = 1 };

            Uloga uloga2 = obj.O as Uloga;
            a.Glumac = glumac1;
            a.Film = film1;

            // Act
            bool rez1 = a.Equals(uloga2);
            bool rez2 = uloga2?.Equals(a) ?? false;

            // Assert
            Assert.AreEqual(obj.AreEqual, rez1);
            Assert.AreEqual(obj.AreEqual, rez2);
        }

        private static IEnumerable<PomocnaTestKlasa> GetTestObjects()
        {
            Uloga uloga1 = new Uloga();
            Uloga uloga2 = new Uloga();
            Uloga uloga3 = new Uloga();
            Uloga uloga4 = new Uloga();
            Film film1 = new Film() { Id = 1 };
            Film film2 = new Film() { Id = 2 };
            Glumac glumac1 = new Glumac() { Id = 1 };
            Glumac glumac2 = new Glumac() { Id = 2 };
            Film film = new Film() { Id = 1 };
            uloga1.Film = film1;
            uloga1.Glumac= glumac1;
            uloga2.Film= film2;
            uloga2.Glumac = glumac1;
            uloga3.Film = film1;
            uloga3.Glumac = glumac2;
            uloga4.Film = film2;
            uloga4.Glumac = glumac2;
            // Return a collection of MyObject instances to be used as test cases
            yield return new PomocnaTestKlasa(uloga1, true);
            yield return new PomocnaTestKlasa(uloga2, false);
            yield return new PomocnaTestKlasa(uloga3, false);
            yield return new PomocnaTestKlasa(uloga4, false);
            yield return new PomocnaTestKlasa(film, false);
        }
    }
}
