using BecareDomain.Models;
using BecareDomain.Service;
using BecareService.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecareService.Repository
{
    public class HospitalRepository : IHospital
    {

        BecareContext context;
        public HospitalRepository(BecareContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Hospital>> GetAll()
        {
            try
            {
                return await context.Hospital.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
