using Domen.Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Film : IDomenObjekat
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public Zanr Zanr { get; set; }
        public bool Prikazan { get; set; } = false;
        public List<Uloga> Uloge { get; set; }
        public List<OcenaFilma> Ocene { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Film film &&
                   Id == film.Id;
        }

        public override string ToString()
        {
            return $"{Naziv}({Zanr})";
        }
        public string TableName => "Film";

        public string InsertValues => $"'{Naziv}',{(int)this.Zanr}, {Help.Instance.boolToNumber(Prikazan)}";

        public string PrimarniKljuc => $"id = {Id}";

        public string Joins => "";

        public string Update => $"Naziv='{Naziv}', Zanr = {(int)Zanr}, Prikazan = {Help.Instance.boolToNumber(Prikazan)}";

        public string Output => "output inserted.id";

        public string Search(string kriterijum)
        {
            return $"LEFT JOIN Uloga ON Film.ID = Uloga.FilmID LEFT JOIN Glumac ON Uloga.GlumacID = Glumac.ID WHERE Film.Prikazan = 1 AND " +
                $" (Film.Naziv LIKE '{kriterijum}%' OR Uloga.Ime LIKE '{kriterijum}%' OR CONCAT(Glumac.Ime,' ',Glumac.Prezime) LIKE '{kriterijum}%')";
        }

        public IDomenObjekat GetObj(SqlDataReader reader)
        {
            Film rez = new Film();
            rez.Id = (int)reader["Id"];
            rez.Naziv = (string)reader["Naziv"];
            rez.Zanr = (Zanr)reader["Zanr"];
            rez.Prikazan = (bool)reader["Prikazan"];
            rez.Uloge = new List<Uloga>();
            rez.Ocene = new List<OcenaFilma>();
            return rez;
        }


    }
}
