using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOVratiSveOceneZaGlumca : OsnovaSistemskihOperacija
    {
        public Glumac Glumac { get; set; }
        protected override void IzvrsiSistemskuOperaciju()
        {
            List<IDomenObjekat> listaOg = repository.GetAllWhere(new OcenaGlumca(), $"Where GlumacID = {Glumac.Id}");
            foreach (IDomenObjekat og in listaOg)
            {
                if(og!=null)
                Glumac.Ocene.Add((OcenaGlumca)og);
            }
        }
    }
}
