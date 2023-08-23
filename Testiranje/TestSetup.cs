using DbBroker;
using Domen;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testiranje
{
    [SetUpFixture]
    internal class TestSetup
    {
        public static IDbRepository<IDomenObjekat> repository;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            DbBroker.DbConnection.test = true; repository = new GenericRepository();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            DbBroker.DbConnection.test = false; repository.Close();
        }
    }
}
