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
    /// <summary>
    /// Predstavlja film koji u sebi sadrzi id, naziv filma, zanr filma, da li je trenutno prikazan,
    /// listu uloga koje se prijavljuje u filmu, listu ocena koje je film dobio.
    /// Implementira interfejs IDomenObjekat.
    /// </summary>
    [Serializable]
    public class Film : IDomenObjekat
    {
        /// <summary>
        /// Get i set metoda za id koji predstavlja primarni kljuc za film.
        /// </summary>
        /// <value>Id koji predstavlja primarni kljuc za film.</value>
        public int Id { get; set; }
        /// <summary>
        /// Get i set metoda za naziv filma.
        /// </summary>
        /// <value>Naziv filma.</value>
        public string Naziv { get; set; }
        /// <summary>
        /// Get i set metoda za zanr filma.
        /// </summary>
        /// <value>Zanr filma</value>
        public Zanr Zanr { get; set; }
        /// <summary>
        /// Get i set metoda za boolean koji pokazuje da li je film prikazan.
        /// </summary>
        /// <value>Boolean koji pokazuje da li je film prikazan.</value>
        public bool Prikazan { get; set; } = false;
        /// <summary>
        /// Get i set metoda za listu uloga koje se pojavljuju u filmu.
        /// </summary>
        /// <value>Lista uloga koje se pojavljuju u filmu.</value>
        public List<Uloga> Uloge { get; set; }
        /// <summary>
        /// Get i set metoda za listu ocena filma.
        /// </summary>
        /// <value>Lista ocena filma.</value>
        public List<OcenaFilma> Ocene { get; set; }

        /// <summary>
        /// Metoda koja proverava da li je prosledjen objekat film i da li ima isti id.
        /// </summary>
        /// <param name="obj">objekat sa kojim se uporedjuje</param>
        /// <returns>true - ako je prosledjen objekat film i da li ima isti id. false - ako nije.</returns>
        public override bool Equals(object obj)
        {
            return obj is Film film &&
                   Id == film.Id;
        }
        /// <summary>
        /// Metoda koja vraca string sa nazivom filma i zanrom u zagradi.
        /// </summary>
        /// <returns>string sa nazivom filma i zanrom u zagradi.</returns>
        public override string ToString()
        {
            return $"{Naziv}({Zanr})";
        }
        /// <inheritdoc/>
        public string TableName => "Film";
        /// <inheritdoc/>
        public string InsertValues => $"'{Naziv}',{(int)this.Zanr}, {Help.Instance.boolToNumber(Prikazan)}";
        /// <inheritdoc/>
        public string PrimarniKljuc => $"id = {Id}";
        /// <inheritdoc/>
        public string Joins => "";
        /// <inheritdoc/>
        public string Update => $"Naziv='{Naziv}', Zanr = {(int)Zanr}, Prikazan = {Help.Instance.boolToNumber(Prikazan)}";
        /// <inheritdoc/>
        public string Output => "output inserted.id";
        /// <inheritdoc/>
        public string Search(string kriterijum)
        {
            return $"LEFT JOIN Uloga ON Film.ID = Uloga.FilmID LEFT JOIN Glumac ON Uloga.GlumacID = Glumac.ID WHERE Film.Prikazan = 1 AND " +
                $" (Film.Naziv LIKE '{kriterijum}%' OR Uloga.Ime LIKE '{kriterijum}%' OR CONCAT(Glumac.Ime,' ',Glumac.Prezime) LIKE '{kriterijum}%')";
        }
        /// <inheritdoc/>
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
