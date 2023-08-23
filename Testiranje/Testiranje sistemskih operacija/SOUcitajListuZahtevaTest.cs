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
    internal class SOUcitajListuZahtevaTest
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
            SOUcitajListuZahteva so = new SOUcitajListuZahteva();
            List<ZahtevZaFilm> listaZahteva = new List<ZahtevZaFilm>();
            List<Uloga> listaUloga2 = new List<Uloga>();
            listaUloga2.Add((Uloga)TestSetup.repository.Get(new Uloga()
            {
                Film = new Film() { Id = 2 },
                Glumac = new Glumac() { Id = 1 }
            }
            ));
            listaUloga2.Add((Uloga)TestSetup.repository.Get(new Uloga()
            {
                Film = new Film() { Id = 2 },
                Glumac = new Glumac() { Id = 2 }
            }
            ));
            List<Uloga> listaUloga1002 = new List<Uloga>();
            listaUloga1002.Add((Uloga)TestSetup.repository.Get(new Uloga()
            {
                Film = new Film() { Id = 3 },
                Glumac = new Glumac() { Id = 1 }
            }
            ));
            listaZahteva.Add((ZahtevZaFilm)TestSetup.repository.Get(new ZahtevZaFilm() { Id = 2 }));
            listaZahteva.Add((ZahtevZaFilm)TestSetup.repository.Get(new ZahtevZaFilm() { Id = 1002 }));
            listaZahteva[0].Uloge = listaUloga2;
            listaZahteva[1].Uloge = listaUloga1002;
            so.IzvrsiSistemskuOperaciju();

            Assert.NotNull(so.ListaZahteva);
            for (int i = 0; i < listaZahteva.Count; i++)
            {
                Assert.NotNull(so.ListaZahteva[i]);
                Assert.NotNull(so.ListaZahteva[i].Film);
                Assert.AreEqual(so.ListaZahteva[i].Id, listaZahteva[i].Id);
                Assert.AreEqual(so.ListaZahteva[i].Film.Id, listaZahteva[i].Film.Id);
                Assert.AreEqual(so.ListaZahteva[i].Obradjen, listaZahteva[i].Obradjen);
                Assert.AreEqual(so.ListaZahteva[i].Odobren, listaZahteva[i].Odobren);
                for (int j = 0; j < listaZahteva[i].Uloge.Count; j++)
                {
                    Assert.NotNull(so.ListaZahteva[i].Uloge[j]);
                    Assert.NotNull(so.ListaZahteva[i].Uloge[j].Film);
                    Assert.NotNull(so.ListaZahteva[i].Uloge[j].Glumac);
                    Assert.AreEqual(so.ListaZahteva[i].Uloge[j].Film.Id, listaZahteva[i].Uloge[j].Film.Id);
                    Assert.AreEqual(so.ListaZahteva[i].Uloge[j].Glumac.Id, listaZahteva[i].Uloge[j].Glumac.Id);
                    Assert.AreEqual(so.ListaZahteva[i].Uloge[j].Ime, listaZahteva[i].Uloge[j].Ime);
                    Assert.AreEqual(so.ListaZahteva[i].Uloge[j].JeGlavna, listaZahteva[i].Uloge[j].JeGlavna);
                }
            }

        }
    }
}
