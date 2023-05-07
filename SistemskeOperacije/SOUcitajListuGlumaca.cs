using DbBroker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOUcitajListuGlumaca : OsnovaSistemskihOperacija
    {
        public List<Glumac> UcitanaLista { get; set; }

        protected override void IzvrsiSistemskuOperaciju()
        {
            UcitanaLista = new List<Glumac>();
            List<IDomenObjekat> lista = repository.GetAllWhere(new Glumac(), $"WHERE Prikazan = 1");
            foreach (IDomenObjekat objekat in lista)
            {
                UcitanaLista.Add((Glumac)objekat);
            }
        }
    }
}
