using DbBroker;
using Domen.Exceptions;
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
    internal class SOUcitavanjeZahtevaZaGlumcaTest
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
        public void TestIzvrsiSistemskuOperaciju_Uspesno()
        {
            SOUcitavanjeZahtevaZaGlumca so = new SOUcitavanjeZahtevaZaGlumca();
            so.Id = 1;
            ZahtevZaGlumca zahtevZaGlumca = new ZahtevZaGlumca()
            {
                Id = 1,
                Obradjen = false,
                Odobren = false,
                Glumac = new Glumac() { Id = 2, Ime = "Imetest2", Prezime = "Prezimetest2", Godiste = 2001, Pol = (Pol)0, Prikazan = false }
            };

            so.IzvrsiSistemskuOperaciju();

            Assert.NotNull(so.ZahtevZaGlumca);
            Assert.AreEqual(so.ZahtevZaGlumca.Id, zahtevZaGlumca.Id);
            Assert.AreEqual(so.ZahtevZaGlumca.Obradjen, zahtevZaGlumca.Obradjen);
            Assert.AreEqual(so.ZahtevZaGlumca.Odobren, zahtevZaGlumca.Odobren);
            Assert.NotNull(so.ZahtevZaGlumca.Glumac);
            Assert.AreEqual(so.ZahtevZaGlumca.Glumac.Id, zahtevZaGlumca.Glumac.Id);
            Assert.AreEqual(so.ZahtevZaGlumca.Glumac.Ime, zahtevZaGlumca.Glumac.Ime);
            Assert.AreEqual(so.ZahtevZaGlumca.Glumac.Prezime, zahtevZaGlumca.Glumac.Prezime);
            Assert.AreEqual(so.ZahtevZaGlumca.Glumac.Godiste, zahtevZaGlumca.Glumac.Godiste);
            Assert.AreEqual(so.ZahtevZaGlumca.Glumac.Pol, zahtevZaGlumca.Glumac.Pol);
            Assert.AreEqual(so.ZahtevZaGlumca.Glumac.Prikazan, zahtevZaGlumca.Glumac.Prikazan);
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju_ObradjenZahtev()
        {
            SOUcitavanjeZahtevaZaGlumca so = new SOUcitavanjeZahtevaZaGlumca();
            so.Id = 2;

            Assert.Catch<MissingZahtevException>(so.IzvrsiSistemskuOperaciju);
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju_NepostojeciId()
        {
            SOUcitavanjeZahteva so = new SOUcitavanjeZahteva();
            so.Id = 99;

            Assert.Catch<MissingZahtevException>(so.IzvrsiSistemskuOperaciju);
        }
    }
}
