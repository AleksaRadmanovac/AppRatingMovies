using DbBroker;
using Domen;
using Domen.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOPrikaziGlumca : OsnovaSistemskihOperacija
    {
        public int GlumacID { get; set; }
        public Glumac Rez { get; set; }
        protected override void IzvrsiSistemskuOperaciju()
        {
            Glumac glumac = (Glumac)repository.Get(new Glumac() { Id = GlumacID });
            if (glumac.Prikazan) Rez = glumac;
            else { throw new MissingGlumacException(); }
        }
    }
}
