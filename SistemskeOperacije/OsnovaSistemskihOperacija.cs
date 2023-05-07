using DbBroker;
using Domen;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public abstract class OsnovaSistemskihOperacija
    {
        public IDbRepository<IDomenObjekat> repository;

        public OsnovaSistemskihOperacija()
        {
            repository = new GenericRepository();
        }

        public void Izvrsi() 
        {
            try
            {
                IzvrsiSistemskuOperaciju();
                repository.Commit();
            }
            catch (Exception ex)
            {
                repository.Rollback();
                throw ex;
            }
            finally
            { 
                repository.Close();
            } 
        }

        protected abstract void IzvrsiSistemskuOperaciju();

    }
}
