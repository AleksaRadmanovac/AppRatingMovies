using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    /// <summary>
    /// Predstavlja interfejs koji implementiraju svi domenski objekti,
    /// u sebi sadrzi stringove potrebne za pozivanje sql upita.
    /// </summary>
    public interface IDomenObjekat
    {
        /// <summary>
        /// Get metoda za string koji predstavlja ime tabele.
        /// </summary>
        string TableName { get; }
        /// <summary>
        /// Get metoda za string koji predstavlja atribute koji se koriste pri insert sql upitu.
        /// </summary>
        string InsertValues { get; }
        /// <summary>
        /// Get metoda za string koji predstavlja atribut koji je primarni kljuc.
        /// </summary>
        string PrimarniKljuc { get; }
        /// <summary>
        /// Get metoda za string koji predstavlja sve join-ove koji su pri select sql upitu.
        /// </summary>
        string Joins { get; }
        /// <summary>
        /// Get metoda za string koji predstavlja sve atribute koje je potrebno izmeniti pri update sql upitu.
        /// </summary>
        string Update { get; }
        /// <summary>
        /// Get metoda za string koji predstavlja novi generisani id iz insert sql upita.
        /// </summary>
        string Output { get; }
        /// <summary>
        /// Funkcija koja vraca string koji predstavlja deo sql upita koji ce nam omoguciti pretrazivanje domenskog objekta.
        /// </summary>
        /// <param name="kriterijum">string po kojem pretrazujemo tabelu</param>
        /// <returns>string koji prestavlja deo sql upita koji ce nam omoguciti pretrazivanje.</returns>
        string Search(string kriterijum);
        /// <summary>
        /// Funkcija koja vraca domenski objekat procitan iz baze.
        /// </summary>
        /// <param name="reader">SqlDataReader reader pomocu kojeg citamo objekat</param>
        /// <returns>domenski objekat</returns>
        IDomenObjekat GetObj(SqlDataReader reader);

    }
}
