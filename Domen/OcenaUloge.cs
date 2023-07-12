using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    /// <summary>
    /// Ocena uloge koja sadrzi korisnika koji je ocenio ulogu, uloga koja je ocenjena, ocenu i komentar.
    /// Implementira interfejs IDomenObjekat.
    /// </summary>
    [Serializable]
    public class OcenaUloge : IDomenObjekat
    {
        /// <summary>
        /// Get i set metoda za korisnika koji je dao ocenu.
        /// </summary>
        public Korisnik Korisnik { get; set; }
        /// <summary>
        /// Get i set metoda za ulogu koja je ocenjena.
        /// </summary>
        public Uloga Uloga { get; set; } = new Uloga();
        /// <summary>
        /// Get i set metoda za broj koji predstavlja ocenu uloge.
        /// </summary>
        public int Ocena { get; set; }
        /// <summary>
        /// Get i set metoda za komentar.
        /// </summary>
        public string Komentar { get; set; }
/// <inheritdoc/>

        public string TableName => "OcenaUloge";

        public string InsertValues => $"{Korisnik.Id}, {Uloga.Film.Id}, {Uloga.Glumac.Id}, {Ocena}, '{Komentar}'";

        public string PrimarniKljuc => $"OcenaUloge.KorisnikID = {Korisnik.Id} AND OcenaUloge.FilmID = {Uloga.Film.Id} AND OcenaUloge.GlumacID = {Uloga.Glumac.Id}";

        public string Joins => $"INNER JOIN Korisnik ON OcenaUloge.KorisnikID = Korisnik.ID INNER JOIN Uloga ON OcenaUloge.FilmID = Uloga.FilmID and OcenaUloge.GlumacID = Uloga.GlumacID {Uloga.Joins}";

        public string Update => $"KorisnikID={Korisnik.Id}, FilmID = {Uloga.Film.Id}, GlumacID = {Uloga.Glumac.Id}, Ocena = {Ocena}, Komentar = '{Komentar}'";

        public string Output => "";

        public IDomenObjekat GetObj(SqlDataReader reader)
        {
            OcenaUloge rez = new OcenaUloge();
            rez.Korisnik = new Korisnik();
            rez.Uloga = new Uloga();
            rez.Korisnik.Id = (int)reader["id"];
            rez.Korisnik.Username = (string)reader[6];
            rez.Korisnik.Password = (string)reader[7];
            rez.Korisnik.Pol = (Pol)reader[8];
            rez.Uloga.Ime = (string)reader[11];
            rez.Uloga.JeGlavna = (bool)reader[12];
            rez.Uloga.Film = new Film();
            rez.Uloga.Film.Id = (int)reader[9];
            rez.Uloga.Film.Naziv = (string)reader[14];
            rez.Uloga.Film.Zanr = (Zanr)reader[15];
            rez.Uloga.Film.Prikazan = (bool)reader[16];
            rez.Uloga.Glumac = new Glumac();
            rez.Uloga.Glumac.Id = (int)reader[10];
            rez.Uloga.Glumac.Ime = (string)reader[18];
            rez.Uloga.Glumac.Prezime = (string)reader[19];
            rez.Uloga.Glumac.Godiste = (int)reader[20];
            rez.Uloga.Glumac.Pol = (Pol)reader[21];
            rez.Uloga.Glumac.Prikazan = (bool)reader[22];
            rez.Ocena = (int)reader["Ocena"];
            rez.Komentar = (string)reader["Komentar"];
            return rez;
        }

        public string Search(string kriterijum)
        {
            throw new NotImplementedException();
        }
    }
}
