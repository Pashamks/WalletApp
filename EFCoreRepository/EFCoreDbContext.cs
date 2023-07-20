using EFCoreRepository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCoreRepository
{
    public class EFCoreDbContext : DbContext
    {
        private readonly string _connectionString;
        public EFCoreDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(_connectionString);
        }
        public DbSet<EfTransactionModel> Transaction { get; set; }
    }
}
