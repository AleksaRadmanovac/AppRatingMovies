using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    /// <summary>
    /// Predstavlja glumca koji sadrzi id, ime glumca, prezime glumca, godiste glumca, pol glumca,
    /// da li je prikazan, lista ocena za tog glumca
    /// </summary>
    [Serializable]
    public class Glumac : IDomenObjekat
    {
        /// <summary>
        /// Get i set metoda za id koji predstavlja primarni kljuc za glumca.
        /// </summary>
        /// <value>Id koji predstavlja primarni kljuc za glumca.</value>
        public int Id { get; set; }
        /// <summary>
        /// Get i set metoda za ime glumca.
        /// </summary>
        /// <value>Ime glumca.</value>
        public string Ime { get; set; }
        /// <summary>
        /// Get i set metoda za prezime glumca.
        /// </summary>
        public string Prezime { get; set; }
        /// <summary>
        /// Get i set metoda za godiste glumca.
        /// </summary>
        /// <value>Godiste glumca.</value>
        public int Godiste { get; set; }
        /// <summary>
        /// Get i set metoda za pol glumca.
        /// </summary>
        /// <value>Pol glumca.</value>
        public Pol Pol { get; set; }
        /// <summary>
        /// Get i set metoda za boolean koji pokazuje da li je glumac prikazan.
        /// </summary>
        /// <value>Boolean koji pokazuje da li je glumac prikazan.</value>
        public bool Prikazan { get; set; } = false;
        /// <summary>
        /// Get i set metoda za listu ocena glumca.
        /// </summary>
        /// <value>Lista ocena glumca.</value>
        public List<OcenaGlumca> Ocene { get; set; } = new List<OcenaGlumca>();
        /// <summary>
        /// Metoda koja proverava da li je prosledjen objekat glumac i da li ima isti id.
        /// </summary>
        /// <param name="obj">objekat sa kojim se uporedjuje</param>
        /// <returns>true - ako je prosledjen objekat glumac i da li ima isti id. false - ako nije.</returns>
        public override bool Equals(object obj)
        {
            return obj is Glumac glumac &&
                   Id == glumac.Id;
        }
        /// <summary>
        /// Metoda koja vraca string sa imenom i prezimenom.
        /// </summary>
        /// <returns>string sa imenom i prezimenom.</returns>
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
        /// <inheritdoc/>

        public string TableName => "Glumac";
        /// <inheritdoc/>
        public string InsertValues => $"'{Ime}', '{Prezime}', {Godiste}, {(int)Pol}, {Help.Instance.boolToNumber(Prikazan)}";
        /// <inheritdoc/>
        public string PrimarniKljuc => $"id = {Id}";
        /// <inheritdoc/>
        public string Joins => "";
        /// <inheritdoc/>
        public string Update => $"Ime='{Ime}', Prezime = '{Prezime}', Godine = {Godiste}, Pol = {(int)Pol}, Prikazan = {Help.Instance.boolToNumber(Prikazan)}";
        /// <inheritdoc/>
        public string Search(string kriterijum)
        {
            return $"LEFT JOIN Uloga ON Glumac.ID = Uloga.GlumacID LEFT JOIN Film ON Uloga.FilmID = Film.ID WHERE Glumac.Prikazan = 1 AND " +
                $" (Film.Naziv LIKE '{kriterijum}%' OR Uloga.Ime LIKE '{kriterijum}%' OR CONCAT(Glumac.Ime,' ',Glumac.Prezime) LIKE '{kriterijum}%')";
        }
        /// <inheritdoc/>
        public string Output => "output inserted.id";

        /// <inheritdoc/>
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
