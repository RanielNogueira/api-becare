using BecareDomain.Models;
using Microsoft.EntityFrameworkCore;

namespace BecareService.Data
{
    public class BecareContext : DbContext
    {
        public BecareContext(DbContextOptions builder):base(builder)
        {

        }
        public DbSet<Hospital> Hospital { get; set; }
    }
}
