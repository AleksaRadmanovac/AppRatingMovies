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
    
    internal class SODodajUloguTest
    {
        [SetUp] public void SetUp() 
        {
        }

        [TearDown] public void TearDown() 
        {
            TestSetup.repository.Rollback();
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju()
        {
            Uloga uloga = new Uloga();
            uloga.Film = new Film();
            uloga.Glumac = new Glumac();
            uloga.Ime = "Imetest";
            uloga.JeGlavna = true;
            uloga.Film.Id = 4;
            uloga.Film.Naziv = "FilmTest4";
            uloga.Film.Zanr = (Zanr)4;
            uloga.Film.Prikazan = true;
            uloga.Glumac.Id = 1;
            uloga.Glumac.Ime = "Imetest";
            uloga.Glumac.Prezime = "Prezimetest";
            uloga.Glumac.Godiste = 2000;
            uloga.Glumac.Pol = (Pol)1;
            uloga.Glumac.Prikazan = true;
            SODodajUlogu so = new SODodajUlogu();
            so.Uloga = uloga;
            so.IzvrsiSistemskuOperaciju();
            Uloga rez = (Uloga)TestSetup.repository.Get(uloga);
            Assert.IsNotNull(rez);
            Assert.NotNull(rez.Glumac);
            Assert.NotNull(rez.Film);
            Assert.AreEqual(uloga.Ime, rez.Ime);
            Assert.AreEqual(uloga.JeGlavna, rez.JeGlavna);
            Assert.AreEqual(uloga.Film.Id, rez.Film.Id);
            Assert.AreEqual(uloga.Film.Naziv, rez.Film.Naziv);
            Assert.AreEqual(uloga.Film.Zanr, rez.Film.Zanr);
            Assert.AreEqual(uloga.Film.Prikazan, rez.Film.Prikazan);
            Assert.AreEqual(uloga.Glumac.Id, rez.Glumac.Id);
            Assert.AreEqual(uloga.Glumac.Ime, rez.Glumac.Ime);
            Assert.AreEqual(uloga.Glumac.Prezime, rez.Glumac.Prezime);
            Assert.AreEqual(uloga.Glumac.Godiste, rez.Glumac.Godiste);
            Assert.AreEqual(uloga.Glumac.Pol, rez.Glumac.Pol);
            Assert.AreEqual(uloga.Glumac.Prikazan, rez.Glumac.Prikazan);


        }
    }
}
