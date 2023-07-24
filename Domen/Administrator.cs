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
        /// <value>Id koji predstavlja primarni kljuc za administratora.</value>
        public int Id { get; set; }
        /// <summary>
        /// Get i set metoda za username naloga administratora.
        /// </summary>
        /// <value>Username naloga administratora.</value>
        public string Username { get; set; }
        /// <summary>
        /// Get i set metoda za passworda naloga administratora.
        /// </summary>
        /// <value>Password naloga administratora.</value>
        public string Password { get; set; }
        /// <summary>
        /// Get i set metoda za broj zahteva koje je administrator obradio.
        /// </summary>
        /// <value>Broj zahteva koje je administrator obradio.</value>
        public int BrojObradjenihZahteva { get; set; }
        
        /// <inheritdoc/>
        public string TableName => "Administrator";
        /// <inheritdoc/>
        public string InsertValues => $"'{Username}', '{Password}', {BrojObradjenihZahteva}";
        /// <inheritdoc/>
        public string PrimarniKljuc => $"id = {Id}";
        /// <inheritdoc/>
        public string Joins => "";
        /// <inheritdoc/>
        public string Update => $"Username='{Username}', Password = '{Password}', BrojObradjenihZahteva = {BrojObradjenihZahteva}";
        /// <inheritdoc/>
        public string Output => "";
        /// <inheritdoc/>
        public IDomenObjekat GetObj(SqlDataReader reader)
        {
            Administrator rez = new Administrator();
            rez.Id = (int)reader["Id"];
            rez.Username = (string)reader["Username"];
            rez.Password = (string)reader["Password"];
            rez.BrojObradjenihZahteva = (int)reader["BrojObradjenihZahteva"];
            return rez;
        }
        /// <inheritdoc/>
        public string Search(string kriterijum)
        {
            throw new NotImplementedException();
        }
    }
}
