using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    /// <summary>
    /// Predstavlja nalog administratora koji u sebi sadrzi id, username, password i broj obradjenih zahteva tog administratora.
    /// Implementira interfejs IDomenObjekat.
    /// </summary>
    [Serializable]
    public class Administrator : IDomenObjekat
    {

        /// <summary>
        /// Get i set metoda za id koji predstavlja primarni kljuc za administratora.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Get i set metoda za username naloga administratora.
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Get i set metoda za passworda naloga administratora.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Get i set metoda za broj zahteva koje je administrator obradio.
        /// </summary>
        public int BrojObradjenihZahteva { get; set; }
/// <inheritdoc/>

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
