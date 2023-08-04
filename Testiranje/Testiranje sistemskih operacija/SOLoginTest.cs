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
    internal class SOLoginTest
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
        public void TestIzvrsiSistemskuOperaciju_AdminUspesan()
        {
            SOLogin so = new SOLogin();
            so.loginZahtev = new Domen.Communication.LoginZahtev();
            so.loginZahtev.Administrator = true;
            so.loginZahtev.Username = "AdminTest";
            so.loginZahtev.Password = "AdminTest";
            so.IzvrsiSistemskuOperaciju();
            Assert.NotNull( so.Nalog );
            Assert.IsInstanceOf(typeof(Administrator), so.Nalog);
            Assert.True(so.Uspesan);
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju_AdminNeuspesan()
        {
            SOLogin so = new SOLogin();
            so.loginZahtev = new Domen.Communication.LoginZahtev();
            so.loginZahtev.Administrator = true;
            so.loginZahtev.Username = "AdminTest";
            so.loginZahtev.Password = "pogresnaSifra";
            so.IzvrsiSistemskuOperaciju();
            Assert.Null(so.Nalog);
            Assert.False(so.Uspesan);
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju_KorisnikUspesan()
        {
            SOLogin so = new SOLogin();
            so.loginZahtev = new Domen.Communication.LoginZahtev();
            so.loginZahtev.Administrator = false;
            so.loginZahtev.Username = "KorisnikTest";
            so.loginZahtev.Password = "KorisnikTest";
            so.IzvrsiSistemskuOperaciju();
            Assert.NotNull(so.Nalog);
            Assert.IsInstanceOf(typeof(Korisnik), so.Nalog);
            Assert.True(so.Uspesan);
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju_KorisnikNeuspesan()
        {
            SOLogin so = new SOLogin();
            so.loginZahtev = new Domen.Communication.LoginZahtev();
            so.loginZahtev.Administrator = true;
            so.loginZahtev.Username = "KorisnikTest";
            so.loginZahtev.Password = "pogresnaSifra";
            so.IzvrsiSistemskuOperaciju();
            Assert.Null(so.Nalog);
            Assert.False(so.Uspesan);
        }
    }
}
