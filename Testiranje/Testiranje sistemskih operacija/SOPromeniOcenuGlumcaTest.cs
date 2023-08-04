using DbBroker;
using Domen;
using NUnit.Framework;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testiranje.Testiranje_sistemskih_operacija
{
    internal class SOPromeniOcenuGlumcaTest
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
        public void TestIzvrsiSistemskuOperaciju()
        {
            SOPromeniOcenuGlumca so = new SOPromeniOcenuGlumca();
            OcenaGlumca ocenaGlumca = new OcenaGlumca()
            {
                Korisnik = new Korisnik() { Id = 1 },
                Glumac = new Glumac() { Id = 1 },
                Ocena = 3,
                Komentar = "Dobar"          
            };
            so.OcenaGlumca = ocenaGlumca;
            so.IzvrsiSistemskuOperaciju();
            OcenaGlumca rez = (OcenaGlumca)repository.Get(new OcenaGlumca()
            {
                Korisnik = new Korisnik() { Id = 1 },
                Glumac = new Glumac() { Id = 1 },
            });

            Assert.NotNull(rez);
            Assert.NotNull(rez.Glumac);
            Assert.NotNull(rez.Korisnik);
            Assert.AreEqual(rez.Glumac.Id, ocenaGlumca.Glumac.Id);
            Assert.AreEqual(rez.Korisnik.Id, ocenaGlumca.Korisnik.Id);
            Assert.AreEqual(rez.Ocena, 3);
            Assert.AreEqual(rez.Komentar, "Dobar");


        }
    }
}
