using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAccounting.Models;

namespace CarAccounting._Repositories.Services
{
    public class ServicesRepository : BaseRepository, IServicesRepository
    {
        public ServicesRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(Service serviceModel)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Service VALUES (@name)";
                command.Parameters.Add("@model", DbType.String).Value = serviceModel.ServiceName;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(Service serviceModel)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Service SET ServiceName=@name";
                command.Parameters.Add("@mark", DbType.Int32).Value = serviceModel.ServiceId;
                command.Parameters.Add("@model", DbType.String).Value = serviceModel.ServiceName;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Service WHERE ServiceId=@id";
                command.Parameters.Add("@id", DbType.Int32).Value = id;
                command.ExecuteNonQuery();
            }
        }
        //TODO: Не проверено, нужно доработать
        public IEnumerable<Service> GetServiceByEngineType(int id)
        {
            var servicesList = new List<Service>();
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ServiceName FROM Service";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var service = new Service();
                        service.ServiceId = reader.GetInt32(0);
                        service.ServiceName = reader[1].ToString();
                        servicesList.Add(service);
                    }
                }
            }

            return servicesList;
        }

    }
}
