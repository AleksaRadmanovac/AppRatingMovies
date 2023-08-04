using DbBroker;
using Domen.Exceptions;
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
    internal class SORegistracijaAdministratoraTest
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
        public void TestIzvrsiSistemskuOperaciju_Uspesan()
        {
            Administrator admin = new Administrator() { Username = "AdminTest3", Password = "AdminTest3" };
            SORegistracijaAdministratora so = new SORegistracijaAdministratora();
            so.Administrator = admin;
            so.IzvrsiSistemskuOperaciju();
            List<IDomenObjekat> rez = repository.GetAll(admin);
            bool p = false;
            foreach (IDomenObjekat o in rez)
            {
                if (((Administrator)o).Username == "AdminTest3") p = true;
            }
            Assert.True(p);
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju_UsernamePostoji()
        {
            Administrator admin = new Administrator() { Username = "AdminTest", Password = "AdminTest" };
            SORegistracijaAdministratora so = new SORegistracijaAdministratora();
            so.Administrator = admin;
            Assert.Catch<UsernamePostojiException>(so.IzvrsiSistemskuOperaciju);
        }
    }
}
