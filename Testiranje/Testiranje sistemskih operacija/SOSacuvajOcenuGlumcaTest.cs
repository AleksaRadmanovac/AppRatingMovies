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
    internal class SOSacuvajOcenuGlumcaTest
    {
   
        [SetUp]
        public void SetUp()
        {
           
        }

        [TearDown]
        public void TearDown()
        {
            TestSetup.repository.Rollback();
           
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju()
        {
            SOSacuvajOcenuGlumca so = new SOSacuvajOcenuGlumca();
            OcenaGlumca ocenaGlumca = new OcenaGlumca() { Glumac = new Glumac() { Id = 1 }, Korisnik = new Korisnik() { Id = 2 }, Ocena = 3, Komentar = "Dobar" };
            so.OcenaGlumca = ocenaGlumca;
            so.IzvrsiSistemskuOperaciju();
            OcenaGlumca rez = (OcenaGlumca)TestSetup.repository.Get(ocenaGlumca);

            Assert.NotNull(rez);
            Assert.NotNull(rez.Glumac);
            Assert.NotNull(rez.Korisnik);
            Assert.AreEqual(rez.Glumac.Id, ocenaGlumca.Glumac.Id);
            Assert.AreEqual(rez.Korisnik.Id, ocenaGlumca.Korisnik.Id);
            Assert.AreEqual(rez.Ocena, ocenaGlumca.Ocena);
            Assert.AreEqual(rez.Komentar, ocenaGlumca.Komentar);
        }
    }
}
