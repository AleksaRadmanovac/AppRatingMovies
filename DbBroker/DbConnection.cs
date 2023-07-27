using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbBroker
{
    public class DbConnection
    {
        private SqlConnection connection;
        private SqlTransaction transaction;
        public static bool test = false;

        public void NovaKonekcija()
        {
            if (test) connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=seminarskiTest;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            else connection = new SqlConnection(ConfigurationManager.ConnectionStrings["psdb"].ConnectionString);

        }

        public void OtvoriKonekciju()
        {
            if (!JeSpremna())
            {
                NovaKonekcija();
                connection.Open();
            }
        }

        public bool JeSpremna()
        {
            return connection != null && connection.State != ConnectionState.Closed;
        }

        public SqlCommand CreateCommand(string sql = "")
        {
            if(transaction?.Connection == null) transaction = connection.BeginTransaction();
            return new SqlCommand(sql, connection, transaction);
        }

        public void Commit()
        {
            transaction.Commit();
        }


        public void Rollback() 
        {
            transaction.Rollback();
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
