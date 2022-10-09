using System.Collections.Generic;

namespace CarAccounting.Models
{
    public class EngineType
    {
        public int EngineId { get; set; }
        public string EngineName { get; set; }
        public HashSet<Service> TypeOfWork { get; set; }
    }
}
