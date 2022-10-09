using System.Collections.Generic;
using CarAccounting.Models;

namespace CarAccounting._Repositories.Cars
{
    public interface ICarRepository
    {
        void Add(Car carModel);
        void Edit(Car carModel);
        void Delete(int id);
        IEnumerable<Car> GetAllCars();
        IEnumerable<Car> GetCarByValue(string value);
    }
}
