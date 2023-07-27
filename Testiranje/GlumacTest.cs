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
        public IDbRepository<IDomenObjekat> repository;
        [SetUp] public void SetUp() { a = new Glumac(); DbBroker.DbConnection.test = true; }

        [TearDown] public void TearDown() { a = null; DbBroker.DbConnection.test = false; }

        [Test]
        public void TestGetObj()
        {
            a.Id = 1;
            a.Ime = "Imetest";
            a.Prezime = "Prezimetest";
            a.Godiste = 2000;
            a.Pol = (Pol)1;
            a.Prikazan = true;

            repository = new GenericRepository();
            Glumac rez = (Glumac)repository.Get(a);

            Assert.NotNull(rez);
            Assert.AreEqual(a.Id, rez.Id);
            Assert.AreEqual(a.Ime, rez.Ime);
            Assert.AreEqual(a.Prezime, rez.Prezime);
            Assert.AreEqual(a.Pol, rez.Pol);
            Assert.AreEqual(a.Prikazan, rez.Prikazan);
        }
    }
}
