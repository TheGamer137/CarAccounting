using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data.SqlTypes;
using CarAccounting.Models;

namespace CarAccounting._Repositories.Cars
{
    public class CarRepository : BaseRepository, ICarRepository
    {
        public CarRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(Car carModel)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Car VALUES (@id, @mark, @model, @numberplate, @dateofwork, @engineid, @serviceid)";
                command.Parameters.Add("@id", DbType.Int32).Value = carModel.CarId;
                command.Parameters.Add("@mark", DbType.String).Value = carModel.CarMark;
                command.Parameters.Add("@model", DbType.String).Value = carModel.CarModel;
                command.Parameters.Add("@numberplate", DbType.String).Value = carModel.CarNumberPlate;
                command.Parameters.Add("@dateofwork", DbType.String).Value = carModel.DateOfWork;
                command.Parameters.Add("@engineid", DbType.String).Value = carModel.EngineId;
                command.Parameters.Add("@serviceid", DbType.String).Value = carModel.ServicesId;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(Car carModel)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Car 
                                    SET CarMark=@mark,CarModel= @model,CarNumberPlate= @numberplate, DateOfWork=@dateofwork,EngineId= @engineid,ServiceId= @serviceid 
                                    WHERE CarId=@id";
                command.Parameters.Add("@mark", DbType.String).Value = carModel.CarMark;
                command.Parameters.Add("@model", DbType.String).Value = carModel.CarModel;
                command.Parameters.Add("@numberplate", DbType.String).Value = carModel.CarNumberPlate;
                command.Parameters.Add("@dateofwork", DbType.String).Value = carModel.DateOfWork;
                command.Parameters.Add("@engineid", DbType.String).Value = carModel.EngineId;
                command.Parameters.Add("@serviceid", DbType.String).Value = carModel.ServicesId;
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
                command.CommandText = "DELETE FROM Car WHERE CarId=@id";
                command.Parameters.Add("@id", DbType.Int32).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Car> GetAllCars()
        {
            var carList = new List<Car>();
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Car ORDER BY CarId DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var car = new Car();
                        car.CarId = reader.GetInt32(0);
                        car.CarMark = reader[1].ToString();
                        car.CarModel = reader[2].ToString();
                        car.CarNumberPlate = reader[3].ToString();
                        car.DateOfWork = reader[4].ToString();
                        car.EngineId = reader[5].ToString();
                        car.ServicesId = reader[6].ToString();
                        carList.Add(car);
                    }
                }
            }

            return carList;
        }

        public IEnumerable<Car> GetCarByValue(string value)
        {
            var carList = new List<Car>();
            int carId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string carNumberPlate = value;
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Car WHERE CarNumberPlate=@carnumber ORDER BY CarId DESC";
                command.Parameters.Add("@id", DbType.Int32).Value = carId;
                command.Parameters.Add("@carnumber", DbType.String).Value = carNumberPlate;
                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var car = new Car();
                        car.CarId = reader.GetInt32(0);
                        car.CarMark = reader[1].ToString();
                        car.CarModel = reader[2].ToString();
                        car.CarNumberPlate = reader[3].ToString();
                        car.DateOfWork = reader[4].ToString();
                        car.EngineId = reader[5].ToString();
                        car.ServicesId = reader[6].ToString();
                        carList.Add(car);
                    }
                }
            }
            return carList;
        }
    }
}
