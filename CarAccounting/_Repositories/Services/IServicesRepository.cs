using System.Collections.Generic;
using CarAccounting.Models;

namespace CarAccounting._Repositories.Services
{
    public interface IServicesRepository
    {
        void Add(Service serviceModel);
        void Edit(Service serviceModel);
        void Delete(int id);
        IEnumerable<Service> GetServiceByEngineType(int id);
    }
}
