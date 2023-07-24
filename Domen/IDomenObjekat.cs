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
        /// Get metoda za string koji predstavlja ime tabele u bazi podataka.
        /// </summary>
        /// <value>Ime tabele u bazi podataka.</value>
        string TableName { get; }
        /// <summary>
        /// Get metoda za string koji predstavlja deo insert sql upita vezan za atribute koji se ubacuju.
        /// </summary>
        /// <value>String koji predstavlja deo insert sql upita vezan za atribute koji se ubacuju.</value>
        string InsertValues { get; }
        /// <summary>
        /// Get metoda za string koji predstavlja primarni kljuc.
        /// </summary>
        /// <value>String koji predstavlja primarni kljuc.</value>
        string PrimarniKljuc { get; }
        /// <summary>
        /// Get metoda za string koji predstavlja sve join-ove koji su potrebni pri select sql upitu.
        /// </summary>
        /// <value>String koji predstavlja sve join-ove koji su potrebni pri select sql upitu.</value>
        string Joins { get; }
        /// <summary>
        /// Get metoda za string koji predstavlja sve atribute koje je potrebno izmeniti pri update sql upitu.
        /// </summary>
        /// <value>String koji predstavlja sve atribute koje je potrebno izmeniti pri update sql upitu.</value>
        string Update { get; }
        /// <summary>
        /// Get metoda za string koji definise ime promenljive u kojoj ce se cuvati novi id generisan od strane baze podataka i dodeljuje mu tu generisanu vrednost.
        /// </summary>
        /// <value>String koji definise ime promenljive u kojoj ce se cuvati novi id generisan od strane baze podataka i dodeljuje mu tu generisanu vrednost.</value>
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
