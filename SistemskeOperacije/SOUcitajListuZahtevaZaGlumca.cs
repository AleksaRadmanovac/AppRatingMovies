using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOUcitajListuZahtevaZaGlumca : OsnovaSistemskihOperacija
    {
        public List<ZahtevZaGlumca> ListaZahtevaZaGlumca { get; set; }
        protected override void IzvrsiSistemskuOperaciju()
        {
            ListaZahtevaZaGlumca = new List<ZahtevZaGlumca>();
            List<IDomenObjekat> lista = repository.GetAll(new ZahtevZaGlumca());
            foreach (IDomenObjekat objekat in lista)
            {
                if (!((ZahtevZaGlumca)objekat).Obradjen) ListaZahtevaZaGlumca.Add((ZahtevZaGlumca)objekat);
            }
        }
    }
}
