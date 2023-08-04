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
    internal class SOCuvanjeOdlukeTest
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
        public void TestIzvrsiSistemskuOperaciju_DodavanjeUlogaTrue()
        {
            Administrator admin = new Administrator() { Id = 1, Username = "AdminTest", Password = "AdminTest", BrojObradjenihZahteva = 6 };
            ZahtevZaFilm zahtevZaFilm = new ZahtevZaFilm() { Id = 1002,
                Odobren = true, Obradjen = true, Film = new Film() { Id = 3, Naziv = "FilmTest3", Zanr = (Zanr)3, Prikazan = true }, Administrator = admin };
            List<Uloga> uloge = new List<Uloga>
            {
                new Uloga() { Film = new Film() { Id = 4 , Naziv = "FilmTest4", Zanr = (Zanr)4, Prikazan = true },
                    Glumac = new Glumac() { Id = 1, Ime = "Imetest", Prezime = "Prezimetest",
                        Godiste = 2000, Prikazan = true, Pol = (Pol)1 }, Ime = "Imetest5", JeGlavna = false }
            };
            zahtevZaFilm.Uloge = uloge;
            SOCuvanjeOdluke so = new SOCuvanjeOdluke();
            so.DodavanjeUloga = true;
            so.ZahtevZaFilm = zahtevZaFilm;
            so.IzvrsiSistemskuOperaciju();
            ZahtevZaFilm zahtevRez = (ZahtevZaFilm)repository.Get(zahtevZaFilm);
            Administrator adminRez = (Administrator)repository.Get(admin);
            List<Uloga> rez = new List<Uloga>();
            for(int j = 0; j < zahtevZaFilm.Uloge.Count; j++) {
                Uloga uloga = (Uloga)repository.Get(new Uloga() { Film = new Film() { Id = 4 }, Glumac = new Glumac() { Id = 1 } });
                //Console.WriteLine("" + j);
                //Console.WriteLine(uloga);
                rez.Add(uloga);   
            }
            Assert.NotNull(adminRez);
            Assert.NotNull(zahtevRez);
            Assert.NotNull(rez);
            Assert.AreEqual(zahtevRez.Odobren, true);
            Assert.AreEqual(zahtevRez.Obradjen, true);
            Assert.AreEqual(adminRez.BrojObradjenihZahteva, 6);
            int i = 0;
            foreach (Uloga rezUloga in rez)
            {
                Assert.AreEqual(rezUloga.Film.Id, 4);
                Assert.AreEqual(rezUloga.Glumac.Id, 1);
                Assert.AreEqual(rezUloga.Ime, "Imetest5");
                Assert.AreEqual(rezUloga.JeGlavna, false);
                i++;
            }
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju_DodavanjeUlogaFalse()
        {
            Administrator admin = new Administrator() { Id = 1, Username = "AdminTest", Password = "AdminTest", BrojObradjenihZahteva = 6 };
            ZahtevZaFilm zahtevZaFilm = new ZahtevZaFilm()
            {
                Id = 2,
                Odobren = true,
                Obradjen = true,
                Film = new Film() { Id = 2, Naziv = "FilmTest2", Zanr = (Zanr)3, Prikazan = true },
                Administrator = admin
            };

            SOCuvanjeOdluke so = new SOCuvanjeOdluke();
            so.DodavanjeUloga = false;
            so.ZahtevZaFilm = zahtevZaFilm;
            so.IzvrsiSistemskuOperaciju();
            ZahtevZaFilm zahtevRez = (ZahtevZaFilm)repository.Get(zahtevZaFilm);
            Administrator adminRez = (Administrator)repository.Get(admin);
            Film rez = (Film)repository.Get(new Film() { Id = 2 });

            Assert.NotNull(adminRez);
            Assert.NotNull(zahtevRez);
            Assert.NotNull(rez);
            Assert.AreEqual(zahtevRez.Odobren, true);
            Assert.AreEqual(zahtevRez.Obradjen, true);
            Assert.AreEqual(adminRez.BrojObradjenihZahteva, 6);
            Assert.AreEqual(rez.Id, zahtevZaFilm.Film.Id);
            Assert.AreEqual(rez.Naziv, zahtevZaFilm.Film.Naziv);
            Assert.AreEqual(rez.Zanr, zahtevZaFilm.Film.Zanr);
            Assert.AreEqual(rez.Prikazan, true);
        }

        [Test]
        public void TestIzvrsiSistemskuOperaciju_Neodobren()
        {
            Administrator admin = new Administrator() { Id = 1, Username = "AdminTest", Password = "AdminTest", BrojObradjenihZahteva = 6 };
            ZahtevZaFilm zahtevZaFilm = new ZahtevZaFilm()
            {
                Id = 2,
                Odobren = false,
                Obradjen = true,
                Film = new Film() { Id = 2, Naziv = "FilmTest2", Zanr = (Zanr)3, Prikazan = true },
                Administrator = admin
            };
            List<Uloga> uloge = new List<Uloga>
            {
                new Uloga() { Film = new Film() { Id = 3 , Naziv = "FilmTest4", Zanr = (Zanr)3, Prikazan = true },
                    Glumac = new Glumac() { Id = 1, Ime = "Imetest", Prezime = "Prezimetest",
                        Godiste = 2000, Prikazan = true, Pol = (Pol)1 }, Ime = "Imetest5", JeGlavna = false }
            };
            zahtevZaFilm.Uloge = uloge;
            SOCuvanjeOdluke so = new SOCuvanjeOdluke();
            so.DodavanjeUloga = false;
            so.ZahtevZaFilm = zahtevZaFilm;
            so.IzvrsiSistemskuOperaciju();
            ZahtevZaFilm zahtevRez = (ZahtevZaFilm)repository.Get(zahtevZaFilm);
            Administrator adminRez = (Administrator)repository.Get(admin);
            Film rez = (Film)repository.Get(new Film() { Id = 2 });

            List<Uloga> rezUloge = new List<Uloga>();
            for (int j = 0; j < zahtevZaFilm.Uloge.Count; j++)
            {
                Uloga uloga = (Uloga)repository.Get(new Uloga() { Film = new Film() { Id = 3 }, Glumac = new Glumac() { Id = 1 } });
                //Console.WriteLine("" + j);
                //Console.WriteLine(uloga);
                rezUloge.Add(uloga);
            }

            Assert.NotNull(adminRez);
            Assert.NotNull(zahtevRez);
            Assert.NotNull(rez);
            Assert.AreEqual(zahtevRez.Odobren, false);
            Assert.AreEqual(zahtevRez.Obradjen, true);
            Assert.AreEqual(adminRez.BrojObradjenihZahteva, 6);
            foreach (Uloga uloga in rezUloge)
            {
                Assert.Null(uloga);
            }
                

        }

    }
}
