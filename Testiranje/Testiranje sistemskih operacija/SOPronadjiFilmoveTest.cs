﻿using DbBroker;
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
    internal class SOPronadjiFilmoveTest
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
            SOPronadjiFilmove so = new SOPronadjiFilmove();
            so.Kriterijum = "Imetest";
            so.IzvrsiSistemskuOperaciju();
            SOPrikaziFilm soPrikaziFilm = new SOPrikaziFilm();
            List<Film> listaFilmova = new List<Film>();
            soPrikaziFilm.FilmID = 1;
            soPrikaziFilm.IzvrsiSistemskuOperaciju();
            listaFilmova.Add(soPrikaziFilm.Rez);
            listaFilmova.Add(soPrikaziFilm.Rez);
            soPrikaziFilm.FilmID = 3;
            soPrikaziFilm.IzvrsiSistemskuOperaciju();
            listaFilmova.Add(soPrikaziFilm.Rez);
            for (int i = 0; i < listaFilmova.Count; i++) 
            {
                Assert.NotNull(so.ListaFilmova[i]);
                Assert.AreEqual(so.ListaFilmova[i].Id, listaFilmova[i].Id);
                Assert.AreEqual(so.ListaFilmova[i].Id, listaFilmova[i].Id);
                Assert.AreEqual(so.ListaFilmova[i].Id, listaFilmova[i].Id);
                Assert.AreEqual(so.ListaFilmova[i].Id, listaFilmova[i].Id);
                for (int j = 0; j < so.ListaFilmova[i].Uloge.Count; j++)
                {
                    Assert.NotNull(so.ListaFilmova[i].Uloge[j]);
                    Assert.NotNull(so.ListaFilmova[i].Uloge[j].Glumac);
                    Assert.NotNull(so.ListaFilmova[i].Uloge[j].Film);
                    Assert.AreEqual(so.ListaFilmova[i].Uloge[j].Glumac.Id, listaFilmova[i].Uloge[j].Glumac.Id);
                    Assert.AreEqual(so.ListaFilmova[i].Uloge[j].Film.Id, listaFilmova[i].Uloge[j].Film.Id);
                    Assert.AreEqual(so.ListaFilmova[i].Uloge[j].Ime, listaFilmova[i].Uloge[j].Ime);
                    Assert.AreEqual(so.ListaFilmova[i].Uloge[j].JeGlavna, listaFilmova[i].Uloge[j].JeGlavna);
                }
            }
     

        }
    }
}
