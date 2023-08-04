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
    internal class SOUcitajListuGlumacaTest
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
            SOUcitajListuGlumaca so = new SOUcitajListuGlumaca();
            List<Glumac> listaGlumaca = new List<Glumac>();
            listaGlumaca.Add((Glumac)repository.Get(new Glumac() { Id = 1 }));
            listaGlumaca.Add((Glumac)repository.Get(new Glumac() { Id = 4 }));
            listaGlumaca.Add((Glumac)repository.Get(new Glumac() { Id = 5 }));
            so.IzvrsiSistemskuOperaciju();
            for (int i = 0; i < listaGlumaca.Count; i++)
            {
                Assert.NotNull(so.UcitanaLista[i]);
                Assert.AreEqual(so.UcitanaLista[i].Id, listaGlumaca[i].Id);
                Assert.AreEqual(so.UcitanaLista[i].Ime, listaGlumaca[i].Ime);
                Assert.AreEqual(so.UcitanaLista[i].Prezime, listaGlumaca[i].Prezime);
                Assert.AreEqual(so.UcitanaLista[i].Pol, listaGlumaca[i].Pol);
                Assert.AreEqual(so.UcitanaLista[i].Godiste, listaGlumaca[i].Godiste);
                Assert.True(so.UcitanaLista[i].Prikazan);
            }

        }
    }
}
