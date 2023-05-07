using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class SOVratiSveOceneZaFilm : OsnovaSistemskihOperacija
    {
        public Film Film { get; set; }
       // public List<OcenaFilma> OceneFilma { get; set; }
       // public List<List<OcenaUloge>> OceneUloga { get; set; }

        protected override void IzvrsiSistemskuOperaciju()
        {
            //OceneFilma= new List<OcenaFilma>();
            List<IDomenObjekat> listaOf = repository.GetAllWhere(new OcenaFilma(), $"Where FilmID = {Film.Id}");
            foreach(OcenaFilma of in listaOf ) 
            {
                Film.Ocene.Add(of);
                //OceneFilma.Add(of);
            }

            foreach (Uloga u in Film.Uloge)
            {
                List<IDomenObjekat> listaOu = repository.GetAllWhere(new OcenaUloge(), $"Where Uloga.FilmID = {u.Film.Id} AND Uloga.GlumacID = {u.Glumac.Id}");
                foreach (IDomenObjekat ou in listaOu)
                { 
                    u.Ocene.Add((OcenaUloge)ou);
                }


            }

        }
    }
}
