using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOPromeniOcene : OsnovaSistemskihOperacija
    {
        public OcenaFilma OcenaFilma { get; set; }
        public List<OcenaUloge> ListaOcenaUloga { get; set; }
        protected override void IzvrsiSistemskuOperaciju()
        {
            repository.Update(OcenaFilma);
            foreach (OcenaUloge o in ListaOcenaUloga)
            {
                //if(o.Ocena != 0)
                repository.Update(o);
            }
        }
    }
}
