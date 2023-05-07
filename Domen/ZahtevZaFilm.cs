using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class ZahtevZaFilm : IDomenObjekat
    {
        public int Id { get; set; }
        public bool Odobren { get; set; } = false;
        public bool Obradjen { get; set; } = false;
        public Administrator Administrator { get; set; }
        public Film Film { get; set; }
        public List<Uloga> Uloge { get; set; }

        public string TableName => "ZahtevZaFilm";

        public string InsertValues => $"{Help.Instance.boolToNumber(Odobren)}, {Help.Instance.boolToNumber(Obradjen)}, null, {Film.Id}";

        public string PrimarniKljuc => $"id = '{Id}'";

        public string Joins => "LEFT JOIN Administrator ON ZahtevZaFilm.AdministratorID = Administrator.Id LEFT JOIN Film ON ZahtevZaFilm.FilmID = Film.Id";

        public string Update => $"Odobren={Help.Instance.boolToNumber(Odobren)}, Obradjen = {Help.Instance.boolToNumber(Obradjen)}, AdministratorID = {Administrator.Id}, FilmID = {Film.Id}";

        public string Output => "";

        public IDomenObjekat GetObj(SqlDataReader reader)
        {
            ZahtevZaFilm rez = new ZahtevZaFilm();
            rez.Id = (int)reader["Id"];
            rez.Odobren = (bool)reader["Odobren"];
            rez.Obradjen = (bool)reader["Obradjen"];
            rez.Administrator = new Administrator();
            if (!reader.IsDBNull(3))
            {
                rez.Administrator.Id = (int)reader[5];
                rez.Administrator.Username = (string)reader[6];
                rez.Administrator.Password = (string)reader[7];
                rez.Administrator.BrojObradjenihZahteva = (int)reader[8];
            }
            rez.Film = new Film();
            rez.Film.Id = (int)reader[9];
            if (!reader.IsDBNull(10))
            {
                rez.Film.Naziv = (string)reader[10];
                rez.Film.Zanr = (Zanr)reader[11];
                rez.Film.Prikazan = (bool)reader[12];
            }
            rez.Uloge = new List<Uloga>();
            return rez;
        }

        public string Search(string kriterijum)
        {
            throw new NotImplementedException();
        }

    }
}
