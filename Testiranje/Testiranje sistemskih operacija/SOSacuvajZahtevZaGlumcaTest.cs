﻿using DbBroker;
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
    internal class SOSacuvajZahtevZaGlumcaTest
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
            SOSacuvajZahtevZaGlumca so = new SOSacuvajZahtevZaGlumca();
            Glumac glumac = new Glumac() { Ime = "Imetest5", Prezime = "Prezimetest5", Godiste = 1990, Pol = Pol.Muski, Prikazan = false };
            ZahtevZaGlumca zahtevZaGlumca = new ZahtevZaGlumca() { Glumac = glumac, Obradjen = false, Odobren = false };
            so.Zahtev = zahtevZaGlumca;
            List<IDomenObjekat> listaZahteva = TestSetup.repository.GetAll(new ZahtevZaGlumca());
            so.IzvrsiSistemskuOperaciju();

            List<IDomenObjekat> rez = TestSetup.repository.GetAll(new ZahtevZaGlumca());

            Glumac rezGlumac = (Glumac)TestSetup.repository.Get(glumac);

            Assert.Greater(rez.Count, listaZahteva.Count);

            Assert.NotNull(rezGlumac);
            Assert.AreEqual(rezGlumac.Ime, glumac.Ime);
            Assert.AreEqual(rezGlumac.Prezime, rezGlumac.Prezime);
            Assert.AreEqual(rezGlumac.Godiste, rezGlumac.Godiste);
            Assert.AreEqual(rezGlumac.Pol, rezGlumac.Pol);
            Assert.AreEqual(rezGlumac.Prikazan, rezGlumac.Prikazan);


        }
    }
}
