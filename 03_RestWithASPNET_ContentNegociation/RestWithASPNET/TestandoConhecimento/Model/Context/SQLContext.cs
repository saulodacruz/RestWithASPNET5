using Microsoft.EntityFrameworkCore;
using TestandoConhecimento.Model.Entities;

namespace TestandoConhecimento.Model.Context
{
    public class SQLContext : DbContext
    {
        public SQLContext(DbContextOptions<SQLContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
