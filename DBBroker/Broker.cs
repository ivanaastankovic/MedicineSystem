using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class Broker
    {
        SqlConnection connection;
        SqlTransaction transaction;
        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SeminarskiRadLekovi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public int Update(IEntity entity)
        {
            SqlCommand sqlCommand = new SqlCommand("", connection, transaction);
            sqlCommand.CommandText = $"update {entity.TableName} set {entity.UpdateValue} {entity.SelectWhere}";
            return sqlCommand.ExecuteNonQuery();
        }

        public int GetNewId(IEntity entity)
        {
            SqlCommand sqlCommand = new SqlCommand("", connection, transaction);
            sqlCommand.CommandText = $"select max({entity.Id}) from {entity.TableName}";
            dynamic result = sqlCommand.ExecuteScalar();
            if (result is DBNull)
            {
                return 1;
            }
            return (int)result + 1;
        }

        public int Delete(IEntity entity)
        {
            SqlCommand sqlCommand = new SqlCommand("", connection, transaction);
            sqlCommand.CommandText = $"delete from {entity.TableName} {entity.SelectWhere}";
            return sqlCommand.ExecuteNonQuery();
        }

        public int Insert(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"insert into {entity.TableName} values ({entity.InsertValues})";
            return command.ExecuteNonQuery();
        }

        public List<IEntity> Select(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select * from {entity.TableName} {entity.AliasName} {entity.JoinTable} {entity.JoinCondition} {entity.SelectWhere}";
            SqlDataReader reader = command.ExecuteReader();
            List<IEntity> entities = entity.ReturnReaderResult(reader);
            reader.Close();
            return entities;
        }

         
        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }
        public void RollBack()
        {
            transaction.Rollback();
        }
    }
}
