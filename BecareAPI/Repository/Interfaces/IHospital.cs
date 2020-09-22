using BecareAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BecareAPI.Repository.Interfaces
{
    public interface IHospital
    {
        public ICollection<Hospital> ListaHospitais();
        public ICollection<Hospital> FiltrarHospital(string nome);
    }
}
