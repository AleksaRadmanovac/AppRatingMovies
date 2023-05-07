using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Uloga : IDomenObjekat
    {
        public Film Film { get; set; }
        public Glumac Glumac { get; set; }
        public string Ime { get; set; }
        public bool JeGlavna { get; set; }
        public List<OcenaUloge> Ocene { get; set; }
        public string TableName => "Uloga";
        public override string ToString()
        {
            if (JeGlavna == true) return $"{Glumac.Ime} {Glumac.Prezime} u ulozi {Ime}(glavna)";
            return $"{Glumac.Ime} {Glumac.Prezime} u ulozi {Ime}";
        }
        public override bool Equals(object obj)
        {
            return obj is Uloga uloga &&
                   EqualityComparer<Film>.Default.Equals(Film, uloga.Film) &&
                   EqualityComparer<Glumac>.Default.Equals(Glumac, uloga.Glumac);
        }

        public string InsertValues => $"{Film.Id}, {Glumac.Id}, '{Ime}', {Help.Instance.boolToNumber(JeGlavna)}";

        public string PrimarniKljuc => $"FilmID = {Film.Id} AND GlumacID = {Glumac.Id}";

        public string Joins => "INNER JOIN Film ON Uloga.FilmID = Film.ID INNER JOIN Glumac ON Uloga.GlumacID = Glumac.ID";

        public string Update => $"FilmID={Film.Id}, GlumacID = {Glumac.Id}, Ime = '{Ime}', JeGlavna = {Help.Instance.boolToNumber(JeGlavna)}";

        public string Output => "";

        public IDomenObjekat GetObj(SqlDataReader reader)
        {
            Uloga rez = new Uloga();
            rez.Film = new Film();
            rez.Film.Id = (int)reader[4];
            rez.Film.Naziv = (string)reader[5];
            rez.Film.Zanr = (Zanr)reader[6];
            rez.Film.Prikazan = (bool)reader[7];
            rez.Glumac = new Glumac();
            rez.Glumac.Id = (int)reader[8];
            rez.Glumac.Ime = (string)reader[9];
            rez.Glumac.Prezime = (string)reader[10];
            rez.Glumac.Godiste = (int)reader[11];
            rez.Glumac.Pol = (Pol)reader[12];
            rez.Glumac.Prikazan = (bool)reader[13];
            rez.Ime = (string)reader["Ime"];
            rez.JeGlavna = (bool)reader["JeGlavna"];
            rez.Ocene = new List<OcenaUloge>();
            return rez;
        }



        public string Search(string kriterijum)
        {
            throw new NotImplementedException();
        }


    }
}
