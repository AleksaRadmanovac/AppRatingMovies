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
    internal class SOPronadjiGlumceTest
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
            SOPronadjiGlumce so = new SOPronadjiGlumce();
            so.Kriterijum = "Imetest3";
            so.IzvrsiSistemskuOperaciju();
            List<Glumac> listaGlumaca = new List<Glumac>()
            {
                new Glumac { Id = 1, Ime = "Imetest", Prezime = "Prezimetest", Godiste = 2000, Pol = (Pol)1, Prikazan = true},
                new Glumac { Id = 4, Ime = "Imetest3", Prezime = "Prezimetest3", Godiste = 1999, Pol = (Pol)1, Prikazan = true}
            };
            for (int i = 0; i < listaGlumaca.Count; i++)
            {
                Assert.NotNull(so.ListaGlumaca[i]);
                Assert.AreEqual(so.ListaGlumaca[i].Id, listaGlumaca[i].Id);
                Assert.AreEqual(so.ListaGlumaca[i].Ime, listaGlumaca[i].Ime);
                Assert.AreEqual(so.ListaGlumaca[i].Prezime, listaGlumaca[i].Prezime);
                Assert.AreEqual(so.ListaGlumaca[i].Pol, listaGlumaca[i].Pol);
                Assert.AreEqual(so.ListaGlumaca[i].Prikazan, listaGlumaca[i].Prikazan);
                Assert.AreEqual(so.ListaGlumaca[i].Godiste, listaGlumaca[i].Godiste);
            }

        }
    }
}
