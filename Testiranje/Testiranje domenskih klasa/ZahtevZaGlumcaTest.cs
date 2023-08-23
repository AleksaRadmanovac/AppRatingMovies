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
    internal class ZahtevZaGlumcaTest
    {
        ZahtevZaGlumca a;
        [SetUp] public void SetUp() { a = new ZahtevZaGlumca(); }

        [TearDown] public void TearDown() { a = null; }

        [Test]
        public void TestGetObjNeobradjen()
        {
            a.Id = 1;
            a.Odobren = false;
            a.Obradjen = false;
            a.Glumac = new Glumac();
            a.Glumac.Id = 2;
            a.Glumac.Ime = "Imetest2";
            a.Glumac.Prezime = "Prezimetest2";
            a.Glumac.Godiste = 2001;
            a.Glumac.Pol = (Pol)0;
            a.Glumac.Prikazan = false;
            a.Administrator = new Administrator();

            
            ZahtevZaGlumca rez = (ZahtevZaGlumca)TestSetup.repository.Get(a);

            Assert.IsNotNull(rez);
            Assert.IsNotNull(rez.Glumac);
            Assert.AreEqual(a.Id, rez.Id);
            Assert.AreEqual(a.Obradjen, rez.Obradjen);
            Assert.AreEqual(a.Odobren, rez.Odobren);
            Assert.AreEqual(a.Glumac.Id, rez.Glumac.Id);
            Assert.AreEqual(a.Glumac.Ime, rez.Glumac.Ime);
            Assert.AreEqual(a.Glumac.Prezime, rez.Glumac.Prezime);
            Assert.AreEqual(a.Glumac.Godiste, rez.Glumac.Godiste);
            Assert.AreEqual(a.Glumac.Pol, rez.Glumac.Pol);
            Assert.AreEqual(a.Glumac.Prikazan, rez.Glumac.Prikazan);

        }

        [Test]
        public void TestGetObjObradjen()
        {
            a.Id = 2;
            a.Odobren = true;
            a.Obradjen = true;
            a.Administrator = new Administrator();
            a.Administrator.Id = 1;
            a.Administrator.Username = "AdminTest";
            a.Administrator.Password = "AdminTest";
            a.Administrator.BrojObradjenihZahteva = 5;
            a.Glumac = new Glumac();
            a.Glumac.Id = 1;
            a.Glumac.Ime = "Imetest";
            a.Glumac.Prezime = "Prezimetest";
            a.Glumac.Godiste = 2000;
            a.Glumac.Pol = (Pol)1;
            a.Glumac.Prikazan = true;

            
            ZahtevZaGlumca rez = (ZahtevZaGlumca)TestSetup.repository.Get(a);

            Assert.IsNotNull(rez);
            Assert.IsNotNull(rez.Glumac);
            Assert.AreEqual(a.Id, rez.Id);
            Assert.AreEqual(a.Obradjen, rez.Obradjen);
            Assert.AreEqual(a.Odobren, rez.Odobren);
            Assert.AreEqual(a.Glumac.Id, rez.Glumac.Id);
            Assert.AreEqual(a.Glumac.Ime, rez.Glumac.Ime);
            Assert.AreEqual(a.Glumac.Prezime, rez.Glumac.Prezime);
            Assert.AreEqual(a.Glumac.Godiste, rez.Glumac.Godiste);
            Assert.AreEqual(a.Glumac.Pol, rez.Glumac.Pol);
            Assert.AreEqual(a.Glumac.Prikazan, rez.Glumac.Prikazan);
            Assert.AreEqual(a.Administrator.Id, rez.Administrator.Id);
            Assert.AreEqual(a.Administrator.Username, rez.Administrator.Username);
            Assert.AreEqual(a.Administrator.Password, rez.Administrator.Password);
            Assert.AreEqual(a.Administrator.BrojObradjenihZahteva, rez.Administrator.BrojObradjenihZahteva);

        }
    }
}
