using DbBroker;
using Domen;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Testiranje
{

    internal class FilmTest
    {
        Film a;
        [SetUp] public void SetUp() { a = new Film(); }

        [TearDown] public void TearDown() { a = null; }

        [Test]
        public void TestGetObj()
        {
            a.Id = 1;
            a.Naziv = "FilmTest";
            a.Zanr = (Zanr)2;
            a.Prikazan = true;


            
            Film rez = (Film)TestSetup.repository.Get(a);

            Assert.NotNull(rez);
            Assert.AreEqual(a.Id, rez.Id);
            Assert.AreEqual(a.Naziv, rez.Naziv);
            Assert.AreEqual(a.Zanr, rez.Zanr);
            Assert.AreEqual(a.Prikazan, rez.Prikazan);
        }

        [Test]
        public void TestToString()
        {
            a.Naziv = "Oppenheimer";
            a.Zanr = Zanr.Drama;

            string rez = a.ToString();

            Assert.IsTrue(rez.Contains("Oppenheimer"));
            Assert.IsTrue(rez.Contains("Drama"));
        }

        [Test]
        [TestCaseSource(nameof(GetTestObjects))]
        public void TestEquals(PomocnaTestKlasa obj)
        {
            a.Id = 1;
            Film film2 = obj.O as Film;

            // Act
            bool rez1 = a.Equals(film2);
            bool rez2 = film2?.Equals(a) ?? false;

            // Assert
            Assert.AreEqual(obj.AreEqual, rez1);
            Assert.AreEqual(obj.AreEqual, rez2);
        }

        private static IEnumerable<PomocnaTestKlasa> GetTestObjects()
        {
            Film film1 = new Film() { Id = 1 };
            Film film2 = new Film() { Id = 2 };
            Glumac glumac = new Glumac() { Id = 1 };
            // Return a collection of MyObject instances to be used as test cases
            yield return new PomocnaTestKlasa(film1, true);
            yield return new PomocnaTestKlasa(film2, false);
            yield return new PomocnaTestKlasa(glumac, false);
        }
    }
}
