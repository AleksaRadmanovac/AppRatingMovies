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
    internal class SOPromeniOceneTest
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
            SOPromeniOcene so = new SOPromeniOcene();
            OcenaFilma ocenaFilma = new OcenaFilma()
            {
                Film = new Film() { Id = 1 },
                Ocena = 3,
                Komentar = "Dobar",
                Korisnik = new Korisnik() { Id = 1 }
            };
            List<OcenaUloge> listaOcenaUloga = new List<OcenaUloge>()
            {
                new OcenaUloge()
                {
                    Korisnik = new Korisnik() { Id = 1 },
                    Uloga = new Uloga() { Film = new Film() { Id = 1 }, Glumac = new Glumac(){ Id = 1 } },
                    Ocena = 4,
                    Komentar = "Vrlodobar"
                },
                new OcenaUloge()
                {
                    Korisnik = new Korisnik() { Id = 1 },
                    Uloga = new Uloga() { Film = new Film() { Id = 1 }, Glumac = new Glumac(){ Id = 2 } },
                    Ocena = 4,
                    Komentar = "Vrlodobar"
                }
            };
            so.OcenaFilma = ocenaFilma;
            so.ListaOcenaUloga = listaOcenaUloga;
            so.IzvrsiSistemskuOperaciju();
            OcenaFilma rez = (OcenaFilma)repository.Get(new OcenaFilma()
            {
                Film = new Film() { Id = 1 },

                Korisnik = new Korisnik() { Id = 1 }
            });
            List<OcenaUloge> rezLista = new List<OcenaUloge>();
            foreach (OcenaUloge o in listaOcenaUloga) 
            {
                rezLista.Add((OcenaUloge)repository.Get(o));
            }
            Assert.NotNull(rez);
            Assert.NotNull(rez.Film);
            Assert.NotNull(rez.Korisnik);
            Assert.AreEqual(rez.Film.Id, 1);
            Assert.AreEqual(rez.Korisnik.Id, 1);
            Assert.AreEqual(rez.Ocena, 3);
            Assert.AreEqual(rez.Komentar, "Dobar");
            int i = 1;
            foreach (OcenaUloge o in rezLista)
            {
                Assert.NotNull(o);
                Assert.NotNull(o.Korisnik);
                Assert.NotNull(o.Uloga);
                Assert.AreEqual(o.Korisnik.Id, 1);
                Assert.AreEqual(o.Uloga.Film.Id, 1);
                Assert.AreEqual(o.Uloga.Glumac.Id, i);
                Assert.AreEqual(o.Ocena, 4);
                Assert.AreEqual(o.Komentar, "Vrlodobar");
                i++;
            }



        }
        
        

    }
}
