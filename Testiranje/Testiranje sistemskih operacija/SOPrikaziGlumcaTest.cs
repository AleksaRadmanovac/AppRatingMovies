using DbBroker;
using Domen;
using Domen.Exceptions;
using NUnit.Framework;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testiranje.Testiranje_sistemskih_operacija
{
    internal class SOPrikaziGlumcaTest
    {
        public IDbRepository<IDomenObjekat> repository;
        [SetUp]
        public void SetUp()
        {
            repository = new GenericRepository();
            DbBroker.DbConnection.test = true;
        }

        [TearDown]
        public void TearDown()
        {
            repository.Rollback();
            repository.Close();
            DbBroker.DbConnection.test = false;
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju_Prikazan()
        {
            SOPrikaziGlumca so = new SOPrikaziGlumca();
            so.GlumacID = 1;
            Glumac glumac = new Glumac() { Id = 1, Ime = "Imetest", Prezime = "Prezimetest", Pol = (Pol)1, Godiste = 2000, Prikazan = true};

            so.IzvrsiSistemskuOperaciju();

            Assert.NotNull(so.Rez);
            Assert.AreEqual(so.Rez.Id, glumac.Id);
            Assert.AreEqual(so.Rez.Ime, glumac.Ime);
            Assert.AreEqual(so.Rez.Prikazan, glumac.Prikazan);
            Assert.AreEqual(so.Rez.Pol, glumac.Pol);
            Assert.AreEqual(so.Rez.Godiste, glumac.Godiste);
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju_Neprikazan()
        {
            SOPrikaziGlumca so = new SOPrikaziGlumca();
            so.GlumacID = 2;

            Assert.Catch<MissingGlumacException>(so.IzvrsiSistemskuOperaciju);
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju_SaExceptionom()
        {
            SOPrikaziGlumca so = new SOPrikaziGlumca();
            so.GlumacID = 6;

            Assert.Catch<Exception>(so.IzvrsiSistemskuOperaciju);
        }
    }
}
