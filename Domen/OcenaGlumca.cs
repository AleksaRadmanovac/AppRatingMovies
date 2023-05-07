using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class OcenaGlumca : IDomenObjekat
    {
        public Korisnik Korisnik { get; set; }
        public Glumac Glumac { get; set; }
        public int Ocena { get; set; }
        public string Komentar { get; set; }

        public string TableName => "OcenaGlumca";

        public string InsertValues => $"{Korisnik.Id}, {Glumac.Id}, {Ocena}, '{Komentar}'";

        public string PrimarniKljuc => $"KorisnikID = {Korisnik.Id} AND GlumacID = {Glumac.Id}";

        public string Joins => "INNER JOIN Korisnik ON OcenaGlumca.KorisnikID = Korisnik.ID INNER JOIN Glumac ON OcenaGlumca.GlumacID = Glumac.ID";

        public string Update => $"KorisnikID={Korisnik.Id}, GlumacID = {Glumac.Id}, Ocena = {Ocena}, Komentar = '{Komentar}'";

        public string Output => "";

        public IDomenObjekat GetObj(SqlDataReader reader)
        {
            OcenaGlumca rez = new OcenaGlumca();
            rez.Korisnik = new Korisnik();
            rez.Korisnik.Id = (int)reader[4];
            rez.Korisnik.Username = (string)reader[5];
            rez.Korisnik.Password = (string)reader[6];
            rez.Korisnik.Pol = (Pol)reader[7];
            rez.Glumac = new Glumac();
            rez.Glumac.Id = (int)reader[8];
            rez.Glumac.Ime = (string)reader[9];
            rez.Glumac.Prezime = (string)reader[10];
            rez.Glumac.Godiste = (int)reader[11];
            rez.Glumac.Pol = (Pol)reader[12];
            rez.Glumac.Prikazan = (bool)reader[13];
            rez.Ocena = (int)reader["Ocena"];
            rez.Komentar = (string)reader["Komentar"];
            rez.Glumac.Ocene = new List<OcenaGlumca>();
            return rez;
        }

        public string Search(string kriterijum)
        {
            throw new NotImplementedException();
        }
    }
}
