using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    /// <summary>
    /// Ocena filma koja sadrzi korisnika koji je ocenio film, film koji je ocenjen, ocenu i komentar.
    /// Implementira interfejs IDomenObjekat.
    /// </summary>
    [Serializable]
    public class OcenaFilma : IDomenObjekat
    {
        /// <summary>
        /// Get i set metoda za korisnika koji je dao ocenu.
        /// </summary>
        /// <value>Korisnik koji je dao ocenu.</value>
        public Korisnik Korisnik { get; set; }
        /// <summary>
        /// Get i set metoda za film koji je ocenjen.
        /// </summary>
        /// <value>Film koji je ocenjen.</value>
        public Film Film { get; set; }
        /// <summary>
        /// Get i set metoda za broj koji predstavlja ocenu filma, u rasponu od 1 do 5, gde je 1 najlosija ocena, a 5 najbolja.
        /// </summary>
        /// <value>Broj koji predstavlja ocenu filma, u rasponu od 1 do 5, gde je 1 najlosija ocena, a 5 najbolja.</value>
        public int Ocena { get; set; }
        /// <summary>
        /// Get i set metoda za komentar.
        /// </summary>
        /// <value>Komentar.</value>
        public string Komentar { get; set; }
        /// <inheritdoc/>

        public string TableName => "OcenaFilma";
        /// <inheritdoc/>
        public string InsertValues => $"{Korisnik.Id}, {Film.Id}, {Ocena}, '{Komentar}'";
        /// <inheritdoc/>
        public string PrimarniKljuc => $"KorisnikID = {Korisnik.Id} AND FilmID = {Film.Id}";
        /// <inheritdoc/>
        public string Joins => "INNER JOIN Korisnik ON OcenaFilma.KorisnikID = Korisnik.ID INNER JOIN Film ON OcenaFilma.FilmID = Film.ID";
        /// <inheritdoc/>
        public string Update => $"KorisnikID={Korisnik.Id}, FilmID = {Film.Id}, Ocena = {Ocena}, Komentar = '{Komentar}'";
        /// <inheritdoc/>
        public string Output => "";
        /// <inheritdoc/>
        public IDomenObjekat GetObj(SqlDataReader reader)
        {
            OcenaFilma rez = new OcenaFilma();
            rez.Korisnik = new Korisnik();
            rez.Korisnik.Id = (int)reader[4];
            rez.Korisnik.Username = (string)reader[5];
            rez.Korisnik.Password = (string)reader[6];
            rez.Korisnik.Pol = (Pol)reader[7];
            rez.Film = new Film();
            rez.Film.Id = (int)reader[8];
            rez.Film.Naziv = (string)reader[9];
            rez.Film.Zanr = (Zanr)reader[10];
            rez.Film.Prikazan = (bool)reader[11];
            rez.Ocena = (int)reader["Ocena"];
            rez.Komentar = (string)reader["Komentar"];
            return rez;
        }
        /// <inheritdoc/>
        public string Search(string kriterijum)
        {
            throw new NotImplementedException();
        }
    }
}
