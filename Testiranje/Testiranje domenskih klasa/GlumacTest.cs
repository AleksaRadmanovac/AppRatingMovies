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
    internal class GlumacTest
    {
        Glumac a;
        [SetUp] public void SetUp() { a = new Glumac(); }

        [TearDown] public void TearDown() { a = null; }

        [Test]
        public void TestGetObj()
        {
            a.Id = 1;
            a.Ime = "Imetest";
            a.Prezime = "Prezimetest";
            a.Godiste = 2000;
            a.Pol = (Pol)1;
            a.Prikazan = true;

            Glumac rez = (Glumac)TestSetup.repository.Get(a);

            Assert.NotNull(rez);
            Assert.AreEqual(a.Id, rez.Id);
            Assert.AreEqual(a.Ime, rez.Ime);
            Assert.AreEqual(a.Prezime, rez.Prezime);
            Assert.AreEqual(a.Pol, rez.Pol);
            Assert.AreEqual(a.Prikazan, rez.Prikazan);
        }

        [Test]
        public void TestToString()
        {
            a.Ime = "Aleksa";
            a.Prezime = "Radmanovac";

            string rez = a.ToString();

            Assert.IsTrue(rez.Contains("Aleksa"));
            Assert.IsTrue(rez.Contains("Radmanovac"));
        }

        [Test]
        [TestCaseSource(nameof(GetTestObjects))]
        public void TestEquals(PomocnaTestKlasa obj)
        {
            a.Id = 1;
            Glumac glumac2 = obj.O as Glumac;

            // Act
            bool rez1 = a.Equals(glumac2);
            bool rez2 = glumac2?.Equals(a) ?? false;

            // Assert
            Assert.AreEqual(obj.AreEqual, rez1);
            Assert.AreEqual(obj.AreEqual, rez2);
        }
        private static IEnumerable<PomocnaTestKlasa> GetTestObjects()
        {
            Glumac glumac1 = new Glumac() { Id = 1 };
            Glumac glumac2 = new Glumac() { Id = 2 };
            Film film = new Film() { Id = 1 };
            // Return a collection of MyObject instances to be used as test cases
            yield return new PomocnaTestKlasa(glumac1, true);
            yield return new PomocnaTestKlasa(glumac2, false);
            yield return new PomocnaTestKlasa(film, false);
        }
    }
}
