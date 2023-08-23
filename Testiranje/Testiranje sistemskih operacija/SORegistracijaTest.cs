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
    internal class SORegistracijaTest
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
            //Administrator admin = new Administrator() { Username = "AdminTest3", Password = "AdminTest3" };
            Korisnik korisnik = new Korisnik() { Username = "KorisnikTest4", Password = "KorisnikTest4", Pol = Pol.Muski };
            SORegistracija so = new SORegistracija();
            so.Korisnik = korisnik;
            so.IzvrsiSistemskuOperaciju();
            List<IDomenObjekat> rez = TestSetup.repository.GetAll(korisnik);
            bool p = false;
            foreach (IDomenObjekat o in rez)
            {
                if (((Korisnik)o).Username == "KorisnikTest3") p = true;
            }
            Assert.True(p);
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju_UsernamePostoji()
        {
            //Administrator admin = new Administrator() { Username = "AdminTest3", Password = "AdminTest3" };
            Korisnik korisnik = new Korisnik() { Username = "KorisnikTest", Password = "KorisnikTest", Pol = Pol.Zenski };
            SORegistracija so = new SORegistracija();
            so.Korisnik = korisnik;
            Assert.Catch<UsernamePostojiException>(so.IzvrsiSistemskuOperaciju);
        }
    }
}
