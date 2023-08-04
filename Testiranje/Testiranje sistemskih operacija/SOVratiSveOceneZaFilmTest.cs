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
    internal class SOVratiSveOceneZaFilmTest
    {
        public IDbRepository<IDomenObjekat> repository;
        [SetUp]
        public void SetUp()
        {
            repository = new GenericRepository();
            DbBroker.DbConnection.test = true;
        }

        [TearDown]
        public void TearDown()
        {
            repository.Rollback();
            repository.Close();
            DbBroker.DbConnection.test = false;
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju()
        {
            SOVratiSveOceneZaFilm so = new SOVratiSveOceneZaFilm();
            Film film = new Film() {
                Id = 1,
                Ocene = new List<OcenaFilma>()
            };
            List<Uloga> uloge = new List<Uloga>()
            {
                new Uloga() { Film = film, Glumac = new Glumac() { Id = 1 } },
                new Uloga() { Film = film, Glumac = new Glumac() { Id = 2 } }
            };
            List<Uloga> ulogeTest = new List<Uloga>()
            {
                new Uloga() { Film = film, Glumac = new Glumac() { Id = 1 }, Ocene = new List<OcenaUloge>() },
                new Uloga() { Film = film, Glumac = new Glumac() { Id = 2 }, Ocene = new List<OcenaUloge>() }
            };
            uloge[0].Ocene = new List<OcenaUloge>();
            uloge[1].Ocene = new List<OcenaUloge>();
            film.Uloge = uloge;
            so.Film = film;

            List<OcenaFilma> oceneFilma = new List<OcenaFilma>();
            oceneFilma.Add((OcenaFilma)repository.Get(new OcenaFilma() { Film = film, Korisnik = new Korisnik() { Id = 1 } }));
            oceneFilma.Add((OcenaFilma)repository.Get(new OcenaFilma() { Film = film, Korisnik = new Korisnik() { Id = 2 } }));
            ulogeTest[0].Ocene.Add((OcenaUloge)repository.Get(new OcenaUloge() { Uloga = ulogeTest[0], Korisnik = new Korisnik() { Id=1 } }));
            ulogeTest[1].Ocene.Add((OcenaUloge)repository.Get(new OcenaUloge() { Uloga = ulogeTest[1], Korisnik = new Korisnik() { Id = 1 } }));

            so.IzvrsiSistemskuOperaciju();

            Assert.NotNull(so.Film.Ocene);
            for (int i = 0; i < oceneFilma.Count; i++)
            {
                Assert.NotNull(so.Film.Ocene[i]);
                Assert.NotNull(so.Film.Ocene[i].Film);
                Assert.NotNull(so.Film.Ocene[i].Korisnik);
                Assert.AreEqual(so.Film.Ocene[i].Film.Id, oceneFilma[i].Film.Id);
                Assert.AreEqual(so.Film.Ocene[i].Korisnik.Id, oceneFilma[i].Korisnik.Id);
                Assert.AreEqual(so.Film.Ocene[i].Ocena, oceneFilma[i].Ocena);
                Assert.AreEqual(so.Film.Ocene[i].Komentar, oceneFilma[i].Komentar);
            }
            for (int i = 0; i < ulogeTest.Count; i++)
            {
                for (int j = 0; j < ulogeTest[i].Ocene.Count; j++)
                {
                    Assert.NotNull(so.Film.Uloge[i].Ocene[j]);
                    Assert.NotNull(so.Film.Uloge[i].Ocene[j].Uloga);
                    Assert.NotNull(so.Film.Uloge[i].Ocene[j].Korisnik);
                    Assert.NotNull(so.Film.Uloge[i].Ocene[j].Uloga.Film);
                    Assert.NotNull(so.Film.Uloge[i].Ocene[j].Uloga.Glumac);
                    Assert.AreEqual(so.Film.Uloge[i].Ocene[j].Korisnik.Id, ulogeTest[i].Ocene[j].Korisnik.Id);
                    Assert.AreEqual(so.Film.Uloge[i].Ocene[j].Uloga.Film.Id, ulogeTest[i].Ocene[j].Uloga.Film.Id);
                    Assert.AreEqual(so.Film.Uloge[i].Ocene[j].Uloga.Glumac.Id, ulogeTest[i].Ocene[j].Uloga.Glumac.Id);
                    Assert.AreEqual(so.Film.Uloge[i].Ocene[j].Ocena, ulogeTest[i].Ocene[j].Ocena);
                    Assert.AreEqual(so.Film.Uloge[i].Ocene[j].Komentar, ulogeTest[i].Ocene[j].Komentar);
                }
            }





        }
    }
}
