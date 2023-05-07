using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class OcenaFilma : IDomenObjekat
    {
        public Korisnik Korisnik { get; set; }
        public Film Film { get; set; }
        public int Ocena { get; set; }
        public string Komentar { get; set; }

        public string TableName => "OcenaFilma";

        public string InsertValues => $"{Korisnik.Id}, {Film.Id}, {Ocena}, '{Komentar}'";

        public string PrimarniKljuc => $"KorisnikID = {Korisnik.Id} AND FilmID = {Film.Id}";

        public string Joins => "INNER JOIN Korisnik ON OcenaFilma.KorisnikID = Korisnik.ID INNER JOIN Film ON OcenaFilma.FilmID = Film.ID";

        public string Update => $"KorisnikID={Korisnik.Id}, FilmID = {Film.Id}, Ocena = {Ocena}, Komentar = '{Komentar}'";

        public string Output => "";

        public IDomenObjekat GetObj(SqlDataReader reader)
        {
            OcenaFilma rez = new OcenaFilma();
            rez.Korisnik = new Korisnik();
            rez.Korisnik.Id = (int)reader[4];
            rez.Korisnik.Username = (string)reader[5];
            rez.Korisnik.Password = (string)reader[6];
            rez.Korisnik.Pol = (Pol)reader[7];
            rez.Film = new Film();
            rez.Film.Id = (int)reader[8];
            rez.Film.Naziv = (string)reader[9];
            rez.Film.Zanr = (Zanr)reader[10];
            rez.Film.Prikazan = (bool)reader[11];
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
