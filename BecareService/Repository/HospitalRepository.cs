using BecareDomain.Models;
using BecareDomain.Service;
using BecareService.Data;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecareService.Repository
{
    public class HospitalRepository : IHospital
    {

        BecareContext context;
        IDbConnection connection;
        public HospitalRepository(BecareContext context, IDbConnection connection)
        {
            this.context = context;
            this.connection = connection;
        }

        public async Task<IEnumerable<Hospital>> GetAll()
        {
            try
            {
                return await connection.QueryAsync<Hospital>("select * from beHospital where Cidade like '%São Paulo%'");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<dynamic>> GetSaoPaulo()
        {
            try
            {
                return await connection.QueryAsync("select * from beHospital where Cidade like '%São Paulo%'");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<dynamic>> FiltrarHospital(string name)
        {
            try
            {
                return await connection.QueryAsync($"select * from beHospital where Cidade like '%São Paulo%' and nome like '%{name}%'");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
