using BecareDomain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BecareDomain.Service
{
    public interface IHospital
    {
        public Task<IEnumerable<Hospital>> GetAll();
    }
}
