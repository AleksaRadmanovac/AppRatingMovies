using Domen;
using Domen.Communication;
using Domen.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SORegistracija : OsnovaSistemskihOperacija
    {
        public Korisnik Korisnik { get; set; }

        protected override void IzvrsiSistemskuOperaciju()
        {
           List<IDomenObjekat> lista = repository.GetAll(Korisnik);
            bool p = true;
            foreach (IDomenObjekat korisnik in lista)
            {
                if (((Korisnik)korisnik).Username == Korisnik.Username) p = false;
            }
            if (p)
            {
                repository.Add(Korisnik);
            }
            else
            {
                throw new UsernamePostojiException();
            }
        }
    }
}
