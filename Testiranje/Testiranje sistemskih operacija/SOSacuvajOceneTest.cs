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
    internal class SOSacuvajOceneTest
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
            SOSacuvajOcene so = new SOSacuvajOcene();
            OcenaFilma ocenaFilma = new OcenaFilma()
            { Korisnik = new Korisnik() { Id = 2003 }, Film = new Film() { Id = 1 }, Ocena = 5, Komentar = "Top" };
            so.OcenaFilma = ocenaFilma;
            List<OcenaUloge> listaOcenaUloga = new List<OcenaUloge>()
            {
                new OcenaUloge()
                { Uloga = new Uloga() { Film = ocenaFilma.Film, Glumac = new Glumac() { Id = 1 } }, Ocena = 5, Komentar = "", Korisnik = ocenaFilma.Korisnik},
                new OcenaUloge()
                { Uloga = new Uloga() { Film = ocenaFilma.Film, Glumac = new Glumac() { Id = 2 } }, Ocena = 4, Komentar = "", Korisnik = ocenaFilma.Korisnik }
            };
            so.ListaOcenaUloga = listaOcenaUloga;
            so.IzvrsiSistemskuOperaciju();
            OcenaFilma rezOcenaFilma = (OcenaFilma)repository.Get(ocenaFilma);
            List<OcenaUloge> rezListaOcenaUloga = new List<OcenaUloge>();
            foreach (OcenaUloge ocenaUloge in listaOcenaUloga)
            {
                rezListaOcenaUloga.Add((OcenaUloge)repository.Get(ocenaUloge));
            }

            Assert.NotNull(rezOcenaFilma);
            Assert.NotNull(rezOcenaFilma.Film);
            Assert.NotNull(rezOcenaFilma.Korisnik);
            Assert.AreEqual(rezOcenaFilma.Film.Id, 1);
            Assert.AreEqual(rezOcenaFilma.Korisnik.Id, 2003);
            Assert.AreEqual(rezOcenaFilma.Ocena, 5);
            Assert.AreEqual(rezOcenaFilma.Komentar, "Top");
            for (int i = 0; i < listaOcenaUloga.Count; i++)
            {
                Assert.NotNull(rezListaOcenaUloga[i]);
                Assert.NotNull(rezListaOcenaUloga[i].Korisnik);
                Assert.NotNull(rezListaOcenaUloga[i].Uloga);
                Assert.NotNull(rezListaOcenaUloga[i].Uloga.Film);
                Assert.NotNull(rezListaOcenaUloga[i].Uloga.Glumac);
                Assert.AreEqual(rezListaOcenaUloga[i].Ocena, listaOcenaUloga[i].Ocena);
                Assert.AreEqual(rezListaOcenaUloga[i].Komentar, listaOcenaUloga[i].Komentar);
                Assert.AreEqual(rezListaOcenaUloga[i].Korisnik.Id, listaOcenaUloga[i].Korisnik.Id);
                Assert.AreEqual(rezListaOcenaUloga[i].Uloga.Film.Id, listaOcenaUloga[i].Uloga.Film.Id);
                Assert.AreEqual(rezListaOcenaUloga[i].Uloga.Glumac.Id, listaOcenaUloga[i].Uloga.Glumac.Id);

            }
        }

    }
}
