using CarAccounting.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAccounting._Repositories.EngineTypes
{
    public class EngineTypeRepository : BaseRepository, IEngineTypeRepository
    {
        public EngineTypeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(EngineType engineType)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO EngineType VALUES (@name)";
                command.Parameters.Add("@model", DbType.String).Value = engineType.EngineName;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(EngineType engineType)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE EngineType SET EngineName=@name";
                command.Parameters.Add("@mark", DbType.Int32).Value = engineType.EngineId;
                command.Parameters.Add("@model", DbType.String).Value = engineType.EngineName;
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
                command.CommandText = "DELETE FROM EngineType WHERE EngineId=@id";
                command.Parameters.Add("@id", DbType.Int32).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<EngineType> GetAllEngineTypes()
        {
            var engineList = new List<EngineType>();
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM EngineType";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var engineType = new EngineType();
                        engineType.EngineId = reader.GetInt32(0);
                        engineType.EngineName = reader[1].ToString();
                        engineList.Add(engineType);
                    }
                }
            }

            return engineList;
        }
    }
}
