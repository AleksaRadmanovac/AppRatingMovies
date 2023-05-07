using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbBroker
{
    public interface IRepository<TDomenObjekat> where TDomenObjekat: class
    {
        void Add(TDomenObjekat objekat);
        int AddOutput(TDomenObjekat objekat);
        void Update(TDomenObjekat objekat);
        void Delete(TDomenObjekat objekat);
        TDomenObjekat Get(TDomenObjekat objekat);
        List<TDomenObjekat> GetAll(TDomenObjekat objekat);
        List<TDomenObjekat> GetAllWhere(TDomenObjekat objekat, string uslov);
        List<TDomenObjekat> Search(string kriterijum, IDomenObjekat objekat);


    }
}
