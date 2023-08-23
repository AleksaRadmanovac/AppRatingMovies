using DbBroker;
using Domen;
using Domen.Exceptions;
using NUnit.Framework;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testiranje.Testiranje_sistemskih_operacija
{
    internal class SOUcitavanjeZahtevaTest
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
            SOUcitavanjeZahteva so = new SOUcitavanjeZahteva();
            so.Id = 2;
            ZahtevZaFilm zahtevZaFilm = new ZahtevZaFilm()
            {
                Id = 2,
                Obradjen = false,
                Odobren = false,
                Film = new Film() { Id = 2, Naziv = "FilmTest2", Zanr = (Zanr)3, Prikazan = false }
            };

            so.IzvrsiSistemskuOperaciju();

            Assert.NotNull(so.ZahtevZaFilm);
            Assert.AreEqual(so.ZahtevZaFilm.Id, zahtevZaFilm.Id);
            Assert.AreEqual(so.ZahtevZaFilm.Obradjen, zahtevZaFilm.Obradjen);
            Assert.AreEqual(so.ZahtevZaFilm.Odobren, zahtevZaFilm.Odobren);
            Assert.NotNull(so.ZahtevZaFilm.Film);
            Assert.AreEqual(so.ZahtevZaFilm.Film.Id, zahtevZaFilm.Film.Id);
            Assert.AreEqual(so.ZahtevZaFilm.Film.Naziv, zahtevZaFilm.Film.Naziv);
            Assert.AreEqual(so.ZahtevZaFilm.Film.Zanr, zahtevZaFilm.Film.Zanr);
            Assert.AreEqual(so.ZahtevZaFilm.Film.Prikazan, zahtevZaFilm.Film.Prikazan);
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju_ObradjenZahtev()
        {
            SOUcitavanjeZahteva so = new SOUcitavanjeZahteva();
            so.Id = 4;

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
