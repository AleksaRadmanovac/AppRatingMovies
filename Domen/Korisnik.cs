using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Korisnik : IDomenObjekat
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Pol Pol { get; set; }

        public string TableName => "Korisnik";

        public string InsertValues => $"'{Username}', '{Password}', {(int)Pol}";

        public string PrimarniKljuc => $"id = {Id}";

        public string Joins => "";

        public string Update => $"Username='{Username}', Password = '{Password}', Pol = {(int)Pol}";

        public string Output => "";

        public IDomenObjekat GetObj(SqlDataReader reader)
        {
            Korisnik rez = new Korisnik();
            rez.Id = (int)reader["Id"];
            rez.Username = (string)reader["Username"];
            rez.Password = (string)reader["Password"];
            rez.Pol = (Pol)reader["Pol"];
            return rez;
        }

        public string Search(string kriterijum)
        {
            throw new NotImplementedException();
        }
    }
}
