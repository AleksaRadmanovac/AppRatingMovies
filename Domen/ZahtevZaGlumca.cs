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
        public int Id { get; set; }
        /// <summary>
        /// Get i set metoda za boolean koji predstavlja da li je zahtev za unos glumca u prikazane glumce odobren
        /// ili odbijen.
        /// </summary>
        public bool Odobren { get; set; } = false;
        /// <summary>
        /// Get i set metoda za boolean koji predstavlja da li je zahtev obradjen od strane administratora.
        /// </summary>
        public bool Obradjen { get; set; } = false;
        /// <summary>
        /// Get i set metoda za administratora koji obradjuje zahtev.
        /// </summary>
        public Administrator Administrator { get; set; }
        /// <summary>
        /// Get i set metoda za film koji je predmet zahteva.
        /// </summary>
        public Glumac Glumac { get; set; }
/// <inheritdoc/>

        public string TableName => "ZahtevZaGlumca";

        public string InsertValues => $"{Help.Instance.boolToNumber(Odobren)}, {Help.Instance.boolToNumber(Obradjen)}, null, {Glumac.Id}";

        public string PrimarniKljuc => $"id = '{Id}'";

        public string Joins => "LEFT JOIN Administrator ON ZahtevZaGlumca.AdministratorID = Administrator.Id INNER JOIN Glumac ON ZahtevZaGlumca.GlumacID = Glumac.Id";

        public string Update => $"Odobren={Help.Instance.boolToNumber(Odobren)}, Obradjen = {Help.Instance.boolToNumber(Obradjen)}, AdministratorID = {Administrator.Id}, GlumacID = {Glumac.Id}";

        public string Output => "";

        public int boolToNumber(bool b)
        {
            if (b) return 1;
            return 0;
        }
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

        public string Search(string kriterijum)
        {
            throw new NotImplementedException();
        }
    }
}
