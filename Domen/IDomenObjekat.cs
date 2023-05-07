using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface IDomenObjekat
    {
        string TableName { get; }
        string InsertValues { get; }
        string PrimarniKljuc { get; }
        string Joins { get; }
        string Update { get; }
        string Output { get; }
        string Search(string kriterijum);
        IDomenObjekat GetObj(SqlDataReader reader);

    }
}
