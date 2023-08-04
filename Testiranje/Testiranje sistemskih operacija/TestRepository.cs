using DbBroker;
using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Testiranje.Testiranje_sistemskih_operacija
{
    internal class TestRepository : IDbRepository<IDomenObjekat>
    {
        public bool commit = false;
        public bool close = false;
        public bool rollback = false;
        public void Close()
        {
            close = true;
        }

        public void Commit()
        {
            commit = true;
        }

        public void Rollback()
        {
            rollback = true;
        }

        
        public void Add(IDomenObjekat objekat)
        {
            SqlCommand cmd = DbConnectionFactory.Instance.GetBroker().CreateCommand($"Insert into {objekat.TableName} values ({objekat.InsertValues}) ");
            cmd.ExecuteNonQuery();
        }

        public int AddOutput(IDomenObjekat objekat)
        {
            SqlCommand cmd = DbConnectionFactory.Instance.GetBroker().CreateCommand($"Insert into {objekat.TableName} {objekat.Output} values ({objekat.InsertValues}) ");
            return (int)cmd.ExecuteScalar();
        }

       

        public void Delete(IDomenObjekat objekat)
        {
            SqlCommand cmd = DbConnectionFactory.Instance.GetBroker().CreateCommand($"Delete from {objekat.TableName} where {objekat.PrimarniKljuc}");
            cmd.ExecuteNonQuery();
        }

        public IDomenObjekat Get(IDomenObjekat objekat)
        {
            SqlCommand cmd = DbConnectionFactory.Instance.GetBroker().CreateCommand($"Select * from {objekat.TableName} {objekat.Joins} where {objekat.PrimarniKljuc}");
            SqlDataReader reader = cmd.ExecuteReader();
            // IDomenObjekat rez = new OcenaFilma();
            // while (reader.Read())
            //  {
            IDomenObjekat rez = null;
            try
            {
                if (reader.Read())
                {

                    rez = objekat.GetObj(reader);

                }
            }
            catch (Exception ex) { throw ex; }
            finally { reader.Close(); }
            return rez;
        }

        public List<IDomenObjekat> GetAll(IDomenObjekat objekat)
        {
            List<IDomenObjekat> lista = new List<IDomenObjekat>();
            SqlCommand cmd = DbConnectionFactory.Instance.GetBroker().CreateCommand($"Select * from {objekat.TableName} {objekat.Joins}");
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {

                while (reader.Read())
                {
                    IDomenObjekat rez = objekat.GetObj(reader);
                    lista.Add(rez);
                }
            }
            catch (Exception ex) { throw ex; }
            finally { reader.Close(); }

            return lista;
        }

        public List<IDomenObjekat> GetAllWhere(IDomenObjekat objekat, string uslov)
        {
            List<IDomenObjekat> lista = new List<IDomenObjekat>();
            SqlCommand cmd = DbConnectionFactory.Instance.GetBroker().CreateCommand($"Select * from {objekat.TableName} {objekat.Joins} {uslov}");
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    IDomenObjekat rez = objekat.GetObj(reader);
                    lista.Add(rez);
                }
            }
            catch (Exception ex) { throw ex; }
            finally { reader.Close(); }
            return lista;
        }

        

        public List<IDomenObjekat> Search(string kriterijum, IDomenObjekat objekat)
        {
            List<IDomenObjekat> lista = new List<IDomenObjekat>();
            SqlCommand cmd = DbConnectionFactory.Instance.GetBroker().CreateCommand($"Select * from {objekat.TableName} {objekat.Search(kriterijum)}");
            string s = $"Select * from {objekat.TableName} {objekat.Search(kriterijum)}";
            //distinct {objekat.TableName}.
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    IDomenObjekat rez = objekat.GetObj(reader);
                    lista.Add(rez);
                }
            }
            catch (Exception ex) { throw ex; }
            finally { reader.Close(); }
            return lista;
        }

        public void Update(IDomenObjekat objekat)
        {
            SqlCommand cmd = DbConnectionFactory.Instance.GetBroker().CreateCommand($"Update {objekat.TableName} SET {objekat.Update} WHERE {objekat.PrimarniKljuc}");
            cmd.ExecuteNonQuery();
        }
    }
}