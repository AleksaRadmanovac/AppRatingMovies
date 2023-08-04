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
        public IDbRepository<IDomenObjekat> repository;
        [SetUp] public void SetUp() { a = new Korisnik(); DbBroker.DbConnection.test = true;
            repository = new GenericRepository();
        }

        [TearDown] public void TearDown() { a = null; DbBroker.DbConnection.test = false; repository.Close(); }

        [Test]
        public void TestGetObj()
        {
            a.Id = 1;
            a.Username = "KorisnikTest";
            a.Password = "KorisnikTest";
            a.Pol = (Pol)1;
            Korisnik rez = (Korisnik)repository.Get(a);

            Assert.NotNull(rez);
            Assert.AreEqual(a.Id, rez.Id);
            Assert.AreEqual(a.Username, rez.Username);
            Assert.AreEqual(a.Password, rez.Password);
            Assert.AreEqual(a.Pol, rez.Pol);

        }
    }
}
