using DbBroker;
using Domen;
using Moq;
using NUnit.Framework;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testiranje.Testiranje_sistemskih_operacija
{
    internal class OsnovaSistemskihOperacijaTest
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
        public void TestIzvrsi_Uspesno()
        {
            var so = new SORegistracija();
            so.repository = new TestRepository();
            so.Korisnik = new Korisnik() { Username = "KorisnikNajjaci", Password = "Korisnik", Pol = Pol.Muski};

            so.Izvrsi();

            Assert.True(((TestRepository)so.repository).commit);
            Assert.True(((TestRepository)so.repository).close);
            Assert.False(((TestRepository)so.repository).rollback);
        }

        [Test]
        public void TestIzvrsi_SaExceptionom()
        {
            var so = new SORegistracija();
            so.repository = new TestRepository();
            so.Korisnik = new Korisnik() { Username = "KorisnikTest", Password = "KorisnikTest", Pol = Pol.Zenski };

            Assert.Catch<Exception>(so.Izvrsi);
            Assert.False(((TestRepository)so.repository).commit);
            Assert.True(((TestRepository)so.repository).close);
            Assert.True(((TestRepository)so.repository).rollback);
        }
    }
}
