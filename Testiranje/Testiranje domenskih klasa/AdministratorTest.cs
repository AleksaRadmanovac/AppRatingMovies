using DbBroker;
using Domen;
using NUnit.Framework;
using System.Data.Common;

namespace Testiranje
{
    public class AdministratorTest
    {
        Administrator a;
        public IDbRepository<IDomenObjekat> repository;
        [SetUp] public void SetUp() { a = new Administrator(); DbBroker.DbConnection.test = true; }

        [TearDown] public void TearDown() { a = null; DbBroker.DbConnection.test = false; }
 
        [Test]
        public void TestGetObj()
        {
            a.Id = 1;
            a.Username = "AdminTest";
            a.Password = "AdminTest";
            a.BrojObradjenihZahteva = 5;

            
            repository = new GenericRepository();
            Administrator rez = (Administrator)repository.Get(a);

            Assert.NotNull(rez);
            Assert.AreEqual(a.Id, rez.Id);
            Assert.AreEqual(a.Username, rez.Username);
            Assert.AreEqual(a.Password, rez.Password);
            Assert.AreEqual(a.BrojObradjenihZahteva, rez.BrojObradjenihZahteva);

        }

    }
}
