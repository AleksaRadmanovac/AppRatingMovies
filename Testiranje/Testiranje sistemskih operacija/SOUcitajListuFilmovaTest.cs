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
    internal class SOUcitajListuFilmovaTest
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
        public void TestIzvrsiSistemskuOperaciju()
        {
            SOUcitajListuFilmova so = new SOUcitajListuFilmova();
            List<Film> listaFilmova = new List<Film>();
            listaFilmova.Add((Film)TestSetup.repository.Get(new Film() { Id = 1 }));
            listaFilmova.Add((Film)TestSetup.repository.Get(new Film() { Id = 3 }));
            listaFilmova.Add((Film)TestSetup.repository.Get(new Film() { Id = 4 }));
            so.IzvrsiSistemskuOperaciju();
            for(int i = 0; i < listaFilmova.Count; i++) 
            {
                Assert.NotNull(so.UcitanaLista[i]);
                Assert.AreEqual(so.UcitanaLista[i].Id, listaFilmova[i].Id);
                Assert.AreEqual(so.UcitanaLista[i].Naziv, listaFilmova[i].Naziv);
                Assert.AreEqual(so.UcitanaLista[i].Zanr, listaFilmova[i].Zanr);
                Assert.True(so.UcitanaLista[i].Prikazan);
            }

        }
    }
}
