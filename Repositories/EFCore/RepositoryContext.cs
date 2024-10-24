using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Repositories.EFCore.Config;
using Microsoft.Extensions.Configuration;
namespace Repositories.EFCore
{
    public class RepositoryContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public RepositoryContext(DbContextOptions<RepositoryContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfig());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("sqlConnection"));
        }
    }
}
