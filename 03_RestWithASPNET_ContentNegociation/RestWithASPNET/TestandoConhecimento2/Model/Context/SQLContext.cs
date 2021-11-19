using Microsoft.EntityFrameworkCore;
using TestandoConhecimento2.Model.Entities;

namespace TestandoConhecimento2.Model.Context
{
    public class SQLContext : DbContext
    {
        public SQLContext(DbContextOptions<SQLContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
    }
}
