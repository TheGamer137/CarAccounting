using CarAccounting.Models;
using System.Collections.Generic;

namespace CarAccounting._Repositories.EngineTypes
{
    public interface IEngineTypeRepository
    {
        void Add(EngineType engineType);
        void Edit(EngineType engineType);
        void Delete(int id);
        IEnumerable<EngineType> GetAllEngineTypes();
    }
}
