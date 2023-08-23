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
        [SetUp] public void SetUp() { a = new Administrator(); }

        [TearDown] public void TearDown() { a = null;  }
 
        [Test]
        public void TestGetObj()
        {
            a.Id = 1;
            a.Username = "AdminTest";
            a.Password = "AdminTest";
            a.BrojObradjenihZahteva = 5;

            
            
            Administrator rez = (Administrator)TestSetup.repository.Get(a);

            Assert.NotNull(rez);
            Assert.AreEqual(a.Id, rez.Id);
            Assert.AreEqual(a.Username, rez.Username);
            Assert.AreEqual(a.Password, rez.Password);
            Assert.AreEqual(a.BrojObradjenihZahteva, rez.BrojObradjenihZahteva);

        }

    }
}
