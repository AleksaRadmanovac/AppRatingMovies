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
    internal class SOVratiOceneFilmaTest
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
        public void TestIzvrsiSistemskuOperaciju_Uspesna()
        {
            SOVratiOceneFilma so = new SOVratiOceneFilma();
            OcenaFilma ocenaFilma = new OcenaFilma()
            {
                Korisnik = new Korisnik() { Id = 1 },
                Film = new Film() { Id = 1 },
                Ocena = 5,
                Komentar = ""
            };
            List<OcenaUloge> listaOcenaUloga = new List<OcenaUloge>()
            {
                new OcenaUloge()
                {
                    Korisnik = new Korisnik() { Id = 1 },
                    Uloga = new Uloga()
                    {
                        Film = new Film() { Id = 1 },
                        Glumac = new Glumac() { Id = 1 }
                    },
                    Ocena = 5,
                    Komentar = ""
                },
                new OcenaUloge()
                {
                    Korisnik = new Korisnik() { Id = 1 },
                    Uloga = new Uloga()
                    {
                        Film = new Film() { Id = 1 },
                        Glumac = new Glumac() { Id = 2 }
                    },
                    Ocena = 5,
                    Komentar = ""
                }
            };
            so.OcenaFilma = ocenaFilma;
            so.OcenaFilma.Film.Uloge = new List<Uloga>();
            so.OcenaFilma.Film.Uloge.Add(listaOcenaUloga[0].Uloga);
            so.OcenaFilma.Film.Uloge.Add(listaOcenaUloga[1].Uloga);
            so.ListaOcenaUloga = listaOcenaUloga;

            so.IzvrsiSistemskuOperaciju();

            Assert.NotNull(so.Odgovor);
            Assert.NotNull(so.Odgovor.OcenaFilma);
            Assert.NotNull(so.Odgovor.OcenaFilma.Film);
            Assert.NotNull(so.Odgovor.OcenaFilma.Korisnik);
            Assert.AreEqual(so.Odgovor.OcenaFilma.Film.Id, ocenaFilma.Film.Id);
            Assert.AreEqual(so.Odgovor.OcenaFilma.Korisnik.Id, ocenaFilma.Korisnik.Id);
            Assert.AreEqual(so.Odgovor.OcenaFilma.Ocena, ocenaFilma.Ocena);
            Assert.AreEqual(so.Odgovor.OcenaFilma.Komentar, ocenaFilma.Komentar);
            for (int i = 0; i < listaOcenaUloga.Count; i++)
            {
                Assert.NotNull(so.Odgovor.OceneUloga[i]);
                Assert.NotNull(so.Odgovor.OceneUloga[i].Uloga);
                Assert.NotNull(so.Odgovor.OceneUloga[i].Uloga.Film);
                Assert.NotNull(so.Odgovor.OceneUloga[i].Uloga.Glumac);
                Assert.AreEqual(so.Odgovor.OceneUloga[i].Uloga.Film.Id, listaOcenaUloga[i].Uloga.Film.Id);
                Assert.AreEqual(so.Odgovor.OceneUloga[i].Uloga.Glumac.Id, listaOcenaUloga[i].Uloga.Glumac.Id);
                Assert.AreEqual(so.Odgovor.OceneUloga[i].Ocena, listaOcenaUloga[i].Ocena);
                Assert.AreEqual(so.Odgovor.OceneUloga[i].Komentar, listaOcenaUloga[i].Komentar);
            }
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju_NepostojeciId()
        {
            SOVratiOceneFilma so = new SOVratiOceneFilma();
            OcenaFilma ocenaFilma = new OcenaFilma()
            {
                Korisnik = new Korisnik() { Id = 1 },
                Film = new Film() { Id = 99 },
                Ocena = 5,
                Komentar = ""
            };
            List<OcenaUloge> listaOcenaUloga = new List<OcenaUloge>()
            {
                new OcenaUloge()
                {
                    Korisnik = new Korisnik() { Id = 1 },
                    Uloga = new Uloga()
                    {
                        Film = new Film() { Id = 1 },
                        Glumac = new Glumac() { Id = 1 }
                    },
                    Ocena = 5,
                    Komentar = ""
                },
                new OcenaUloge()
                {
                    Korisnik = new Korisnik() { Id = 1 },
                    Uloga = new Uloga()
                    {
                        Film = new Film() { Id = 1 },
                        Glumac = new Glumac() { Id = 2 }
                    },
                    Ocena = 5,
                    Komentar = ""
                }
            };
            so.OcenaFilma = ocenaFilma;
            so.OcenaFilma.Film.Uloge = new List<Uloga>();
            so.OcenaFilma.Film.Uloge.Add(listaOcenaUloga[0].Uloga);
            so.OcenaFilma.Film.Uloge.Add(listaOcenaUloga[1].Uloga);
            so.ListaOcenaUloga = listaOcenaUloga;

            Assert.Catch<MissingOcenaException>(so.IzvrsiSistemskuOperaciju);

            
        }
    }
}
