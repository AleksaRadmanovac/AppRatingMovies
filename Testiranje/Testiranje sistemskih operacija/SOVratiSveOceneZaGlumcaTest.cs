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
    internal class SOVratiSveOceneZaGlumcaTest
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
            SOVratiSveOceneZaGlumca so = new SOVratiSveOceneZaGlumca();
            Glumac glumac = new Glumac() { Id = 1, Ocene = new List<OcenaGlumca>() };
            List<OcenaGlumca> oceneGlumca = new List<OcenaGlumca>();
            oceneGlumca.Add(new OcenaGlumca() { Glumac = glumac, Korisnik = new Korisnik() { Id= 1}, Ocena = 5, Komentar = "" });
            oceneGlumca.Add(new OcenaGlumca() { Glumac = glumac, Korisnik = new Korisnik() { Id = 2003 }, Ocena = 4, Komentar = "Vrlodobar" });
            so.Glumac = glumac;

            so.IzvrsiSistemskuOperaciju();

            for (int i = 0; i < oceneGlumca.Count; i++)
            {
                Assert.NotNull(so.Glumac.Ocene[i]);
                Assert.NotNull(so.Glumac.Ocene[i].Glumac);
                Assert.NotNull(so.Glumac.Ocene[i].Korisnik);
                Assert.AreEqual(so.Glumac.Ocene[i].Glumac.Id, oceneGlumca[i].Glumac.Id);
                Assert.AreEqual(so.Glumac.Ocene[i].Korisnik.Id, oceneGlumca[i].Korisnik.Id);
                Assert.AreEqual(so.Glumac.Ocene[i].Ocena, oceneGlumca[i].Ocena);
                Assert.AreEqual(so.Glumac.Ocene[i].Komentar, oceneGlumca[i].Komentar);
            }
        }
    }
}
