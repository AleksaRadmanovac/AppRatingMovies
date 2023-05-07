using Domen;
using Domen.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOVratiOcenuGlumca : OsnovaSistemskihOperacija
    {
        public OcenaGlumca OcenaGlumca { get; set; }    

        protected override void IzvrsiSistemskuOperaciju()
        {

                OcenaGlumca = (OcenaGlumca)repository.Get(OcenaGlumca);
                if(OcenaGlumca== null ) { throw new MissingOcenaException(); }
        }
    }
}
