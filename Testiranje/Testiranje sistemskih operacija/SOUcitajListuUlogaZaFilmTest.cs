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
    internal class SOUcitajListuUlogaZaFilmTest
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
            SOUcitajListuUlogaZaFilm so = new SOUcitajListuUlogaZaFilm();
            List<Uloga> listaUloga = new List<Uloga>();
            Film film = new Film() { Id = 1 };
            listaUloga.Add((Uloga)TestSetup.repository.Get(new Uloga() { Glumac = new Glumac() { Id = 1 }, Film = film }));
            listaUloga.Add((Uloga)TestSetup.repository.Get(new Uloga() { Glumac = new Glumac() { Id = 2 }, Film = film }));
            so.FilmID = film.Id;
            so.IzvrsiSistemskuOperaciju();
            
            for (int i = 0; i < listaUloga.Count; i++)
            {
                Assert.NotNull(so.ListaUloga[i]);
                Assert.NotNull(so.ListaUloga[i].Film);
                Assert.NotNull(so.ListaUloga[i].Glumac);
                Assert.AreEqual(so.ListaUloga[i].Glumac.Id, listaUloga[i].Glumac.Id);
                Assert.AreEqual(so.ListaUloga[i].Glumac.Ime, listaUloga[i].Glumac.Ime);
                Assert.AreEqual(so.ListaUloga[i].Glumac.Prezime, listaUloga[i].Glumac.Prezime);
                Assert.AreEqual(so.ListaUloga[i].Glumac.Prikazan, listaUloga[i].Glumac.Prikazan);
                Assert.AreEqual(so.ListaUloga[i].Glumac.Pol, listaUloga[i].Glumac.Pol);
                Assert.AreEqual(so.ListaUloga[i].Glumac.Godiste, listaUloga[i].Glumac.Godiste);
                Assert.AreEqual(so.ListaUloga[i].Film.Id, listaUloga[i].Film.Id);
                Assert.AreEqual(so.ListaUloga[i].Film.Naziv, listaUloga[i].Film.Naziv);
                Assert.AreEqual(so.ListaUloga[i].Film.Prikazan, listaUloga[i].Film.Prikazan);
                Assert.AreEqual(so.ListaUloga[i].Film.Zanr, listaUloga[i].Film.Zanr);
                Assert.AreEqual(so.ListaUloga[i].Ime, listaUloga[i].Ime);
                Assert.AreEqual(so.ListaUloga[i].JeGlavna, listaUloga[i].JeGlavna);
            }

        }
    }
}
