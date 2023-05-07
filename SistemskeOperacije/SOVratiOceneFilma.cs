using Domen;
using Domen.Communication;
using Domen.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOVratiOceneFilma : OsnovaSistemskihOperacija
    {
        public VratiOceneOdgovor Odgovor { get; set; }
        public OcenaFilma OcenaFilma { get; set; }
        public List<OcenaUloge> listaOcenaUloga { get; set; }

        protected override void IzvrsiSistemskuOperaciju()
        {
             
            Odgovor = new VratiOceneOdgovor();
            Odgovor.OcenaFilma = (OcenaFilma)repository.Get(OcenaFilma);
            if(Odgovor.OcenaFilma== null ) throw new MissingOcenaException();
            
            Odgovor.OcenaFilma.Film.Uloge = new List<Uloga>();
            List<IDomenObjekat> lista = repository.GetAllWhere(new Uloga(), $"Where FilmID = {OcenaFilma.Film.Id}");
            foreach (IDomenObjekat objekat in lista)
            {
                Odgovor.OcenaFilma.Film.Uloge.Add((Uloga)objekat);
            }
           
            listaOcenaUloga = new List<OcenaUloge>();
            
            foreach (Uloga uloga in OcenaFilma.Film.Uloge)
            {
                OcenaUloge ou = (OcenaUloge)repository.Get(new OcenaUloge()
                {
                    Korisnik = OcenaFilma.Korisnik,
                    Uloga = uloga
                }
                );
                if(ou != null )
                listaOcenaUloga.Add(ou);
            }
            Odgovor.OceneUloga = listaOcenaUloga;
        }
    }
}
