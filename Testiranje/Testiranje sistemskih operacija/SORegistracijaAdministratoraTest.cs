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
        
        [SetUp]
        public void SetUp()
        {
          
        }

        [TearDown]
        public void TearDown()
        {
            TestSetup.repository.Rollback();
          
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju_Uspesan()
        {
            Administrator admin = new Administrator() { Username = "AdminTest3", Password = "AdminTest3" };
            SORegistracijaAdministratora so = new SORegistracijaAdministratora();
            so.Administrator = admin;
            so.IzvrsiSistemskuOperaciju();
            List<IDomenObjekat> rez = TestSetup.repository.GetAll(admin);
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
