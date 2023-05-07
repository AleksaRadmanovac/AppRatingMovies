using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbBroker
{
    public class DbConnectionFactory
    {
        private static DbConnectionFactory instance;
        private DbConnection Broker = new DbConnection();
        public static DbConnectionFactory Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new DbConnectionFactory();
                }
                return instance;
            }
        }

        private DbConnectionFactory() { }

        public DbConnection GetBroker()
        {
            if (!Broker.JeSpremna())
            {
                Broker.OtvoriKonekciju();
            }
            return Broker;
        }



    }
}
