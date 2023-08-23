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
    internal class SOUcitajListuZahtevaZaGlumcaTest
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
            SOUcitajListuZahtevaZaGlumca so = new SOUcitajListuZahtevaZaGlumca();
            List<ZahtevZaGlumca> listaZahteva = new List<ZahtevZaGlumca>();
            
            listaZahteva.Add((ZahtevZaGlumca)TestSetup.repository.Get(new ZahtevZaGlumca() { Id = 1 }));
            listaZahteva.Add((ZahtevZaGlumca)TestSetup.repository.Get(new ZahtevZaGlumca() { Id = 1004 }));

            so.IzvrsiSistemskuOperaciju();

            Assert.NotNull(so.ListaZahtevaZaGlumca);
            for (int i = 0; i < listaZahteva.Count; i++)
            {
                Assert.NotNull(so.ListaZahtevaZaGlumca[i]);
                Assert.NotNull(so.ListaZahtevaZaGlumca[i].Glumac);
                Assert.AreEqual(so.ListaZahtevaZaGlumca[i].Id, listaZahteva[i].Id);
                Assert.AreEqual(so.ListaZahtevaZaGlumca[i].Glumac.Id, listaZahteva[i].Glumac.Id);
                Assert.AreEqual(so.ListaZahtevaZaGlumca[i].Obradjen, listaZahteva[i].Obradjen);
                Assert.AreEqual(so.ListaZahtevaZaGlumca[i].Odobren, listaZahteva[i].Odobren);
            }

        }
    }
}
