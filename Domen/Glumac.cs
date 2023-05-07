using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Glumac : IDomenObjekat
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Godiste { get; set; }
        public Pol Pol { get; set; }
        public bool Prikazan { get; set; } = false;
        public List<OcenaGlumca> Ocene { get; set; } = new List<OcenaGlumca>();
        public override bool Equals(object obj)
        {
            return obj is Glumac glumac &&
                   Id == glumac.Id;
        }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
        public string TableName => "Glumac";

        public string InsertValues => $"'{Ime}', '{Prezime}', {Godiste}, {(int)Pol}, {Help.Instance.boolToNumber(Prikazan)}";

        public string PrimarniKljuc => $"id = {Id}";
        public string Joins => "";
        public string Update => $"Ime='{Ime}', Prezime = '{Prezime}', Godine = {Godiste}, Pol = {(int)Pol}, Prikazan = {Help.Instance.boolToNumber(Prikazan)}";
        public string Search(string kriterijum)
        {
            return $"LEFT JOIN Uloga ON Glumac.ID = Uloga.GlumacID LEFT JOIN Film ON Uloga.FilmID = Film.ID WHERE Glumac.Prikazan = 1 AND " +
                $" (Film.Naziv LIKE '{kriterijum}%' OR Uloga.Ime LIKE '{kriterijum}%' OR CONCAT(Glumac.Ime,' ',Glumac.Prezime) LIKE '{kriterijum}%')";
        }
        public string Output => "output inserted.id";



        public IDomenObjekat GetObj(SqlDataReader reader)
        {
            Glumac rez = new Glumac();
            rez.Id = (int)reader["Id"];
            rez.Ime = (string)reader["Ime"];
            rez.Prezime = (string)reader["Prezime"];
            rez.Godiste = (int)reader["Godine"];
            rez.Pol = (Pol)reader["Pol"];
            rez.Prikazan = (bool)reader["Prikazan"];
            rez.Ocene = new List<OcenaGlumca>();
            return rez;
        }



    }
}
