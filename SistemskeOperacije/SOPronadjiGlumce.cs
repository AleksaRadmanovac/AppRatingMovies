using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOPronadjiGlumce : OsnovaSistemskihOperacija
    {
        public List<Glumac> ListaGlumaca { get; set; }
        public string Kriterijum { get; set; }

        protected override void IzvrsiSistemskuOperaciju()
        {
            ListaGlumaca = new List<Glumac>();
            List<IDomenObjekat> lista = repository.Search(Kriterijum, new Glumac());
            foreach(IDomenObjekat objekat in lista) 
            {
                if(((Glumac)objekat).Prikazan)
                ListaGlumaca.Add((Glumac)objekat);
            }
        }
    }
}
