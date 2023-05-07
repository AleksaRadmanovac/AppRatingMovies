using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOSacuvajOcenuGlumca : OsnovaSistemskihOperacija
    {
        public OcenaGlumca OcenaGlumca{ get; set; }
        protected override void IzvrsiSistemskuOperaciju()
        {
            repository.Add(OcenaGlumca);
        }
    }
}
