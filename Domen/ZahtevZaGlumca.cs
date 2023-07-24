using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    /// <summary>
    /// Zahtev za glumca koji predstavlja zahtev korisnika administratoru za unos glumca u prikazane glumce,
    /// sadrzi id, boolean o tome da li je odobren, boolean o tome da li je obradjen,
    /// administratora koji obradjuje zahtev, glumca koji je predmet zahteva.
    /// </summary>
    [Serializable]
    public class ZahtevZaGlumca : IDomenObjekat
    {
        /// <summary>
        /// Get i set metoda za id koji predstavlja primarni kljuc.
        /// </summary>
        /// <value>Id koji predstavlja primarni kljuc.</value>
        public int Id { get; set; }
        /// <summary>
        /// Get i set metoda za boolean koji predstavlja da li je zahtev za unos glumca u prikazane glumce odobren
        /// ili odbijen.
        /// </summary>
        /// <value>Da li je zahtev za unos filma u prikazane filmove odobren ili odbijen. True - Odoboren, False - Odbijen.</value>
        public bool Odobren { get; set; } = false;
        /// <summary>
        /// Get i set metoda za boolean koji predstavlja da li je zahtev obradjen od strane administratora.
        /// </summary>
        /// <value>Da li je zahtev obradjen od strane administratora. True - Jeste, False - Nije.</value>
        public bool Obradjen { get; set; } = false;
        /// <summary>
        /// Get i set metoda za administratora koji obradjuje zahtev.
        /// </summary>
        /// <value>Administrator koji obradjuje zahtev.</value>
        public Administrator Administrator { get; set; }
        /// <summary>
        /// Get i set metoda za glumca koji je predmet zahteva.
        /// </summary>
        /// <value>Glumac koji je predmet zahteva.</value>
        public Glumac Glumac { get; set; }
        /// <inheritdoc/>

        public string TableName => "ZahtevZaGlumca";
        /// <inheritdoc/>
        public string InsertValues => $"{Help.Instance.boolToNumber(Odobren)}, {Help.Instance.boolToNumber(Obradjen)}, null, {Glumac.Id}";
        /// <inheritdoc/>
        public string PrimarniKljuc => $"id = '{Id}'";
        /// <inheritdoc/>
        public string Joins => "LEFT JOIN Administrator ON ZahtevZaGlumca.AdministratorID = Administrator.Id INNER JOIN Glumac ON ZahtevZaGlumca.GlumacID = Glumac.Id";
        /// <inheritdoc/>
        public string Update => $"Odobren={Help.Instance.boolToNumber(Odobren)}, Obradjen = {Help.Instance.boolToNumber(Obradjen)}, AdministratorID = {Administrator.Id}, GlumacID = {Glumac.Id}";
        /// <inheritdoc/>
        public string Output => "";
        /// <summary>
        /// Metoda koja konvertuje boolean u integer vrednosti 0 ili 1 u zavisnosti od njegove vrednosti.
        /// </summary>
        /// <param name="b">boolean koji se konvertuje</param>
        /// <returns>integer 0 ili 1. 0 u slucaju da je prosledjeni boolean bio False. 1 u slucaju da je prosledjeni boolean bio True.</returns>
        public int boolToNumber(bool b)
        {
            if (b) return 1;
            return 0;
        }
        /// <inheritdoc/>
        public IDomenObjekat GetObj(SqlDataReader reader)
        {
            ZahtevZaGlumca rez = new ZahtevZaGlumca();
            rez.Id = (int)reader["Id"];
            rez.Odobren = (bool)reader["Odobren"];
            rez.Obradjen = (bool)reader["Obradjen"];
            rez.Administrator = new Administrator();
            if (!reader.IsDBNull(3))
            {
                rez.Administrator.Id = (int)reader[5];
                rez.Administrator.Username = (string)reader[6];
                rez.Administrator.Password = (string)reader[7];
                rez.Administrator.BrojObradjenihZahteva = (int)reader[8];
            }
            rez.Glumac = new Glumac();
            rez.Glumac.Id = (int)reader[9];
            rez.Glumac.Ime = (string)reader[10];
            rez.Glumac.Prezime = (string)reader[11];
            rez.Glumac.Godiste = (int)reader[12];
            rez.Glumac.Pol = (Pol)reader[13];
            rez.Glumac.Prikazan = (bool)reader[14];
            return rez;
        }
        /// <inheritdoc/>
        public string Search(string kriterijum)
        {
            throw new NotImplementedException();
        }
    }
}
