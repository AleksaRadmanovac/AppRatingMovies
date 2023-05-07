using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Administrator : IDomenObjekat
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int BrojObradjenihZahteva { get; set; }

        public string TableName => "Administrator";

        public string InsertValues => $"'{Username}', '{Password}', {BrojObradjenihZahteva}";

        public string PrimarniKljuc => $"id = {Id}";

        public string Joins => "";

        public string Update => $"Username='{Username}', Password = '{Password}', BrojObradjenihZahteva = {BrojObradjenihZahteva}";

        public string Output => "";

        public IDomenObjekat GetObj(SqlDataReader reader)
        {
            Administrator rez = new Administrator();
            rez.Id = (int)reader["Id"];
            rez.Username = (string)reader["Username"];
            rez.Password = (string)reader["Password"];
            rez.BrojObradjenihZahteva = (int)reader["BrojObradjenihZahteva"];
            return rez;
        }

        public string Search(string kriterijum)
        {
            throw new NotImplementedException();
        }
    }
}
