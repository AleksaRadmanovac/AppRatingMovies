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
    internal class FilmTest
    {
        Film a;
        public IDbRepository<IDomenObjekat> repository;
        [SetUp] public void SetUp() { a = new Film(); DbBroker.DbConnection.test = true; }

        [TearDown] public void TearDown() { a = null; DbBroker.DbConnection.test = false; }

        [Test]
        public void TestGetObj()
        {
            a.Id = 1;
            a.Naziv = "FilmTest";
            a.Zanr = (Zanr)2;
            a.Prikazan = true;


            repository = new GenericRepository();
            Film rez = (Film)repository.Get(a);

            Assert.NotNull(rez);
            Assert.AreEqual(a.Id, rez.Id);
            Assert.AreEqual(a.Naziv, rez.Naziv);
            Assert.AreEqual(a.Zanr, rez.Zanr);
            Assert.AreEqual(a.Prikazan, rez.Prikazan);
        }
    }
}
