using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    /// <summary>
    /// Predstavlja nalog korisnika koji u sebi sadrzi id, username korisnika, password korisnika, pol korisnika.
    /// Implementira interfejs IDomenObjekat.
    /// </summary>
    [Serializable]
    public class Korisnik : IDomenObjekat
    {
        /// <summary>
        /// Get i set metoda za id koji predstavlja primarni kljuc.
        /// </summary>
        /// <value>Id koji predstavlja primarni kljuc.</value>
        public int Id { get; set; }
        /// <summary>
        /// Get i set metoda za username korisnika.
        /// </summary>
        /// <value>Username korisnika.</value>
        public string Username { get; set; }
        /// <summary>
        /// Get i set metoda za password korisnika.
        /// </summary>
        /// <value>Password korisnika.</value>
        public string Password { get; set; }
        /// <summary>
        /// Get i set metoda za pol korisnika.
        /// </summary>
        /// <value>Pol korisnika.</value>
        public Pol Pol { get; set; }
        /// <inheritdoc/>

        public string TableName => "Korisnik";
        /// <inheritdoc/>
        public string InsertValues => $"'{Username}', '{Password}', {(int)Pol}";
        /// <inheritdoc/>
        public string PrimarniKljuc => $"id = {Id}";
        /// <inheritdoc/>
        public string Joins => "";
        /// <inheritdoc/>
        public string Update => $"Username='{Username}', Password = '{Password}', Pol = {(int)Pol}";
        /// <inheritdoc/>
        public string Output => "";
        /// <inheritdoc/>
        public IDomenObjekat GetObj(SqlDataReader reader)
        {
            Korisnik rez = new Korisnik();
            rez.Id = (int)reader["Id"];
            rez.Username = (string)reader["Username"];
            rez.Password = (string)reader["Password"];
            rez.Pol = (Pol)reader["Pol"];
            return rez;
        }
        /// <inheritdoc/>
        public string Search(string kriterijum)
        {
            throw new NotImplementedException();
        }
    }
}
