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
    /// <summary>
    /// Apstraktna klasa u kojoj definisemo sve zajednicke delove svake sistemske operacije.
    /// </summary>
    public abstract class OsnovaSistemskihOperacija
    {
        /// <summary>
        /// repozitorijum preko kojeg komuniciramo sa DbConnection-om.
        /// </summary>
        public IDbRepository<IDomenObjekat> repository;

        /// <summary>
        /// Neparametarski konstruktor preko kojeg inicijalizujemo atribut repository.
        /// </summary>
        public OsnovaSistemskihOperacija()
        {
            repository = new GenericRepository();
        }

        /// <summary>
        /// metoda koja izvrsava sistemsku operaciju i commit-uje rad nad bazom.
        /// Ako dodje do exception-a izvrsava se rollback, i baca se taj exception.
        /// </summary>
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

        /// <summary>
        /// apstraktna metoda izvrsavanja sistemske operacije.
        /// </summary>
        protected abstract void IzvrsiSistemskuOperaciju();

    }
}
