

using Afshar_test.Models.entity;
using Microsoft.EntityFrameworkCore;

namespace Alavan.Datalayer.Context
{
    public class AfsharContext : DbContext
    {
        public AfsharContext(DbContextOptions<AfsharContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers{ get; set; }
  

    }
}
