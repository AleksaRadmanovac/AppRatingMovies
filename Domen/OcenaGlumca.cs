using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    /// <summary>
    /// Ocena glumca koja sadrzi korisnika koji je ocenio glumca, glumac koji je ocenjen, ocenu i komentar.
    /// Implementira interfejs IDomenObjekat.
    /// </summary>
    [Serializable]
    public class OcenaGlumca : IDomenObjekat
    {
        /// <summary>
        /// Get i set metoda za korisnika koji je dao ocenu.
        /// </summary>
        /// <value>Korisnik koji je dao ocenu</value>
        public Korisnik Korisnik { get; set; }
        /// <summary>
        /// Get i set metoda za glumca koji je ocenjen.
        /// </summary>
        /// <value>Glumac koji je ocenjen.</value>
        public Glumac Glumac { get; set; }
        /// <summary>
        /// Get i set metoda za broj koji predstavlja ocenu glumca, u rasponu od 1 do 5, gde je 1 najlosija ocena, a 5 najbolja..
        /// </summary>
        /// <value>Broj koji predstavlja ocenu glumca, u rasponu od 1 do 5, gde je 1 najlosija ocena, a 5 najbolja.</value>
        public int Ocena { get; set; }
        /// <summary>
        /// Get i set metoda za komentar.
        /// </summary>
        /// <value>Komentar.</value>
        public string Komentar { get; set; }
        /// <inheritdoc/>

        public string TableName => "OcenaGlumca";
        /// <inheritdoc/>
        public string InsertValues => $"{Korisnik.Id}, {Glumac.Id}, {Ocena}, '{Komentar}'";
        /// <inheritdoc/>
        public string PrimarniKljuc => $"KorisnikID = {Korisnik.Id} AND GlumacID = {Glumac.Id}";
        /// <inheritdoc/>
        public string Joins => "INNER JOIN Korisnik ON OcenaGlumca.KorisnikID = Korisnik.ID INNER JOIN Glumac ON OcenaGlumca.GlumacID = Glumac.ID";
        /// <inheritdoc/>
        public string Update => $"KorisnikID={Korisnik.Id}, GlumacID = {Glumac.Id}, Ocena = {Ocena}, Komentar = '{Komentar}'";
        /// <inheritdoc/>
        public string Output => "";
        /// <inheritdoc/>
        public IDomenObjekat GetObj(SqlDataReader reader)
        {
            OcenaGlumca rez = new OcenaGlumca();
            rez.Korisnik = new Korisnik();
            rez.Korisnik.Id = (int)reader[4];
            rez.Korisnik.Username = (string)reader[5];
            rez.Korisnik.Password = (string)reader[6];
            rez.Korisnik.Pol = (Pol)reader[7];
            rez.Glumac = new Glumac();
            rez.Glumac.Id = (int)reader[8];
            rez.Glumac.Ime = (string)reader[9];
            rez.Glumac.Prezime = (string)reader[10];
            rez.Glumac.Godiste = (int)reader[11];
            rez.Glumac.Pol = (Pol)reader[12];
            rez.Glumac.Prikazan = (bool)reader[13];
            rez.Ocena = (int)reader["Ocena"];
            rez.Komentar = (string)reader["Komentar"];
            rez.Glumac.Ocene = new List<OcenaGlumca>();
            return rez;
        }
        /// <inheritdoc/>
        public string Search(string kriterijum)
        {
            throw new NotImplementedException();
        }
    }
}
