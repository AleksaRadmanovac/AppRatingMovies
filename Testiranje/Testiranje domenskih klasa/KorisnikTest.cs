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
    internal class KorisnikTest
    {
        Korisnik a;
        [SetUp] public void SetUp() { a = new Korisnik();
        }

        [TearDown] public void TearDown() { a = null; }

        [Test]
        public void TestGetObj()
        {
            a.Id = 1;
            a.Username = "KorisnikTest";
            a.Password = "KorisnikTest";
            a.Pol = (Pol)1;
            Korisnik rez = (Korisnik)TestSetup.repository.Get(a);

            Assert.NotNull(rez);
            Assert.AreEqual(a.Id, rez.Id);
            Assert.AreEqual(a.Username, rez.Username);
            Assert.AreEqual(a.Password, rez.Password);
            Assert.AreEqual(a.Pol, rez.Pol);

        }
    }
}
