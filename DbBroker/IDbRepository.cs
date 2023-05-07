using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbBroker
{
    public interface IDbRepository<TDomenObjekat> : IRepository<TDomenObjekat> where TDomenObjekat: class
    {
        void Commit();
        void Rollback();
        void Close();
    }
}
