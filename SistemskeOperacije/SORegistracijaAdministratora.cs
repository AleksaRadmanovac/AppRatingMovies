using Domen;
using Domen.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    /// <summary>
    /// Sistemska operacija registracija adminstratora. Proverava da li vec postoji administrator sa istim username-om, ako ne postoji
    /// dodaje novog administratora u bazu.
    /// Sadrzi u sebi atribut Administrator i override metode IzvrsioSistemskuOperaciju.
    /// Nasledjuje apstraktnu klasu OsnovaSistemskihOperacija.
    /// </summary>
    public class SORegistracijaAdministratora : OsnovaSistemskihOperacija
    {
        /// <summary>
        /// Get i set metoda za administratora koji se registruje.
        /// </summary>
        /// <value>Administrator koji se registruje.</value>
        public Administrator Administrator { get; set; }
        /// <summary>
        /// Metoda za izvsravanje sistemske operacije registracija administratora. Proverava da li vec postoji administrator sa istim username-om,
        /// ako ne postoji dodaje novog administratora u bazu, ako postoji baca exception.
        /// </summary>
        /// <exception cref="UsernamePostojiException">Ako u bazi vec postoji administrator sa istim username-om.</exception>
        protected override void IzvrsiSistemskuOperaciju()
        {
            List<IDomenObjekat> lista = repository.GetAll(Administrator);
            bool p = true;
            foreach (IDomenObjekat administrator in lista)
            {
                if (((Administrator)administrator).Username == Administrator.Username) p = false;
            }
            if (p)
            {
                repository.Add(Administrator);
            }
            else
            {
                throw new UsernamePostojiException();
            }
        }
    }
}
