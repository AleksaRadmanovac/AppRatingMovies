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
    internal class SOVratiOcenuGlumcaTest
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
            SOVratiOcenuGlumca so = new SOVratiOcenuGlumca();
            OcenaGlumca ocenaGlumca = new OcenaGlumca() 
            { 
                Korisnik = new Korisnik() { Id = 1 },
                Glumac = new Glumac() { Id = 1 },
                Ocena = 5,
                Komentar = ""
            };
            so.OcenaGlumca = ocenaGlumca;

            so.IzvrsiSistemskuOperaciju();

            Assert.NotNull(so.OcenaGlumca);
            Assert.NotNull(so.OcenaGlumca.Korisnik);
            Assert.NotNull(so.OcenaGlumca.Glumac);
            Assert.AreEqual(so.OcenaGlumca.Korisnik.Id, ocenaGlumca.Korisnik.Id);
            Assert.AreEqual(so.OcenaGlumca.Glumac.Id, ocenaGlumca.Glumac.Id);
            Assert.AreEqual(so.OcenaGlumca.Komentar, ocenaGlumca.Komentar);
            Assert.AreEqual(so.OcenaGlumca.Ocena, ocenaGlumca.Ocena);
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju_NepostojeciId()
        {
            SOVratiOcenuGlumca so = new SOVratiOcenuGlumca();
            OcenaGlumca ocenaGlumca = new OcenaGlumca()
            {
                Korisnik = new Korisnik() { Id = 99 },
                Glumac = new Glumac() { Id = 1 },
                Ocena = 5,
                Komentar = ""
            };
            so.OcenaGlumca = ocenaGlumca;

            Assert.Catch<MissingOcenaException>(so.IzvrsiSistemskuOperaciju);
        }
    }
}
