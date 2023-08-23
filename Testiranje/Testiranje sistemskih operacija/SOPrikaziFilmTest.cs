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
    internal class SOPrikaziFilmTest
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
        public void TestIzvrsiSistemskuOperaciju_Prikazan()
        {
            Film film = new Film() { Id = 1, Naziv = "FilmTest", Prikazan = true, Zanr = (Zanr)2, };

            List<Uloga> uloge = new List<Uloga>()
            {
                new Uloga()
                {
                    Film = film,
                    Glumac = new Glumac() { Id = 1 },
                    Ime = "Imetest",
                    JeGlavna = true
                },
                new Uloga()
                {
                    Film = film,
                    Glumac = new Glumac() { Id = 2 },
                    Ime = "Imetest2",
                    JeGlavna = false
                }
            };
            film.Uloge = uloge;
            SOPrikaziFilm so = new SOPrikaziFilm();
            so.FilmID = 1;
            so.IzvrsiSistemskuOperaciju();

            Assert.NotNull(so.Rez);
            Assert.AreEqual(so.Rez.Id, film.Id);
            Assert.AreEqual(so.Rez.Naziv, film.Naziv);
            Assert.AreEqual(so.Rez.Prikazan, film.Prikazan);
            Assert.AreEqual(so.Rez.Zanr, film.Zanr);
            for (int i = 0; i < uloge.Count; i++)
            {
                Assert.AreEqual(so.Rez.Uloge[i].Film.Id, film.Uloge[i].Film.Id);
                Assert.AreEqual(so.Rez.Uloge[i].Glumac.Id, film.Uloge[i].Glumac.Id);
                Assert.AreEqual(so.Rez.Uloge[i].Ime, film.Uloge[i].Ime);
                Assert.AreEqual(so.Rez.Uloge[i].JeGlavna, film.Uloge[i].JeGlavna);

            }
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju_Neprikazan()
        {
            Film film = new Film() { Id = 2, Naziv = "FilmTest2", Prikazan = false, Zanr = (Zanr)3, };

            SOPrikaziFilm so = new SOPrikaziFilm();
            so.FilmID = 2;

            Assert.Catch<MissingFilmException>(so.IzvrsiSistemskuOperaciju);
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju_SaExceptionom()
        {
            Film film = new Film() { Id = 6, Naziv = "FilmTest", Prikazan = true, Zanr = (Zanr)2, };

            List<Uloga> uloge = new List<Uloga>()
            {
                new Uloga()
                {
                    Film = film,
                    Glumac = new Glumac() { Id = 1 },
                    Ime = "Imetest",
                    JeGlavna = true
                },
                new Uloga()
                {
                    Film = film,
                    Glumac = new Glumac() { Id = 2 },
                    Ime = "Imetest2",
                    JeGlavna = false
                }
            };
            film.Uloge = uloge;
            SOPrikaziFilm so = new SOPrikaziFilm();
            so.FilmID = 6;

            Assert.Catch<Exception>(so.IzvrsiSistemskuOperaciju);
        }

    }
}
