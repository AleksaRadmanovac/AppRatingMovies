using Domen;
using Domen.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SORegistracijaAdministratora : OsnovaSistemskihOperacija
    {
        public Administrator Administrator { get; set; }
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
