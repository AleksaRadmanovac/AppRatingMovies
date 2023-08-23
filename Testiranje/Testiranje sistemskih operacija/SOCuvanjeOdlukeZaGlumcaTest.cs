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
    internal class SOCuvanjeOdlukeZaGlumcaTest
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
            ZahtevZaGlumca zahtevZaGlumca = new ZahtevZaGlumca()
            {
                Id = 1,
                Administrator = new Administrator() { Id = 1, Username = "AdminTest", Password = "AdminTest", BrojObradjenihZahteva = 6 },
                Glumac = new Glumac() { Id = 2 },
                Obradjen = true,
                Odobren = true
            };
            SOCuvanjeOdlukeZaGlumca so = new SOCuvanjeOdlukeZaGlumca();
            so.ZahtevZaGlumca = zahtevZaGlumca;
            so.IzvrsiSistemskuOperaciju();

            ZahtevZaGlumca rez = (ZahtevZaGlumca)TestSetup.repository.Get(new ZahtevZaGlumca() { Id = 1 });
            Assert.NotNull(rez);
            Assert.AreEqual(rez.Id, 1);
            Assert.AreEqual(rez.Administrator.Id , 1);
            Assert.AreEqual(rez.Glumac.Id , 2);
            Assert.True(rez.Odobren);
            Assert.True(rez.Obradjen);    
        }
    }
}
