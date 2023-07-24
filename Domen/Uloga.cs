using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    /// <summary>
    /// Uloga koja sadrzi film iz kog je uloga, glumac koji glumi u ulozi, ime uloge, da li je ona glavna
    /// i lista ocena te uloge.
    /// Implementira interfejs IDomenObjekat.
    /// </summary>
    [Serializable]
    public class Uloga : IDomenObjekat
    {
        /// <summary>
        /// Get i set metoda za film u kom se pojavljuje uloga.
        /// </summary>
        /// <value>Filma u kom se pojavljuje uloga.</value>
        public Film Film { get; set; }
        /// <summary>
        /// Get i set metoda za glumca koji glumi u ulozi.
        /// </summary>
        /// <value>Glumac koji glumi u ulozi.</value>
        public Glumac Glumac { get; set; }
        /// <summary>
        /// Get i set metoda za ime uloge.
        /// </summary>
        /// <value>Ime uloge.</value>
        public string Ime { get; set; }
        /// <summary>
        /// Get i set metoda za boolean vrednost koja pokazuje da li je uloga glavna(true) ili ne(false).
        /// </summary>
        /// <value>Da li je uloga glavna. True - jeste, False - nije.</value>
        public bool JeGlavna { get; set; }
        /// <summary>
        /// Get i set metoda za listu ocena za ulogu.
        /// </summary>
        /// <value>Lista ocena za ulogu.</value>
        public List<OcenaUloge> Ocene { get; set; }
        /// <summary>
        /// Metoda koja vraca string sa imenom i prezimenom glumca zajedno sa imenom uloge i "(glavna)" ako je uloga glavna..
        /// </summary>
        /// <returns>string sa imenom i prezimenom glumca zajedno sa imenom uloge i "(glavna)" ako je uloga glavna.</returns>
        public override string ToString()
        {
            if (JeGlavna == true) return $"{Glumac.Ime} {Glumac.Prezime} u ulozi {Ime}(glavna)";
            return $"{Glumac.Ime} {Glumac.Prezime} u ulozi {Ime}";
        }
        /// <summary>
        /// Metoda koja proverava da li je prosledjen objekat uloga i poziva equals metodu za film i glumca oba objekta.
        /// </summary>
        /// <param name="obj">objekat sa kojim se uporedjuje</param>
        /// <returns>true - ako je prosledjen objekat uloga i equals metoda za film i glumca su true. false - u suprotnom.</returns>
        public override bool Equals(object obj)
        {
            return obj is Uloga uloga &&
                   EqualityComparer<Film>.Default.Equals(Film, uloga.Film) &&
                   EqualityComparer<Glumac>.Default.Equals(Glumac, uloga.Glumac);
        }
        /// <inheritdoc/>

        public string TableName => "Uloga";
        /// <inheritdoc/>
        public string InsertValues => $"{Film.Id}, {Glumac.Id}, '{Ime}', {Help.Instance.boolToNumber(JeGlavna)}";
        /// <inheritdoc/>
        public string PrimarniKljuc => $"FilmID = {Film.Id} AND GlumacID = {Glumac.Id}";
        /// <inheritdoc/>
        public string Joins => "INNER JOIN Film ON Uloga.FilmID = Film.ID INNER JOIN Glumac ON Uloga.GlumacID = Glumac.ID";
        /// <inheritdoc/>
        public string Update => $"FilmID={Film.Id}, GlumacID = {Glumac.Id}, Ime = '{Ime}', JeGlavna = {Help.Instance.boolToNumber(JeGlavna)}";
        /// <inheritdoc/>
        public string Output => "";
        /// <inheritdoc/>
        public IDomenObjekat GetObj(SqlDataReader reader)
        {
            Uloga rez = new Uloga();
            rez.Film = new Film();
            rez.Film.Id = (int)reader[4];
            rez.Film.Naziv = (string)reader[5];
            rez.Film.Zanr = (Zanr)reader[6];
            rez.Film.Prikazan = (bool)reader[7];
            rez.Glumac = new Glumac();
            rez.Glumac.Id = (int)reader[8];
            rez.Glumac.Ime = (string)reader[9];
            rez.Glumac.Prezime = (string)reader[10];
            rez.Glumac.Godiste = (int)reader[11];
            rez.Glumac.Pol = (Pol)reader[12];
            rez.Glumac.Prikazan = (bool)reader[13];
            rez.Ime = (string)reader["Ime"];
            rez.JeGlavna = (bool)reader["JeGlavna"];
            rez.Ocene = new List<OcenaUloge>();
            return rez;
        }


        /// <inheritdoc/>
        public string Search(string kriterijum)
        {
            throw new NotImplementedException();
        }


    }
}
