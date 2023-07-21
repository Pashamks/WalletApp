using EFCoreRepository.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreRepository
{
    public class EFCoreDbContext : DbContext
    {
        private readonly string _connectionString;
        public EFCoreDbContext(string? connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException("Connection string is null!");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EFUserModel>().HasData(new List<EFUserModel>
            {
                new EFUserModel
                {
                    UserId = 1,
                    FullName = "Pavlo",
                    CardBalance = 0
                },
                new EFUserModel
                {
                    UserId= 2,
                    FullName = "JPMorgan",
                    CardBalance = 0
                }
            });

            modelBuilder.Entity<EfTransactionModel>().HasData(new List<EfTransactionModel>
            {
                new EfTransactionModel
                {
                    TransactionId = 1,
                    TransactionDate = DateTime.Now.AddDays(-1),
                    TransactionDescription = "Card Number Used",
                    IconPath = "https://localhost:7046/img/apple.png",
                    TransactionName = "Apple",
                    UserFrom = "Diana",
                    UserOwnerId = 1,
                    TransactionStatus = Enums.TransactionStatus.Pending,
                    TransactionType = Enums.TransactionType.Credit,
                    TransactionAmount = 14.06m,     
                },
                new EfTransactionModel
                {
                    TransactionId = 2,
                    TransactionDate = DateTime.Now,
                    TransactionDescription = "Chase Bank Natio...",
                    IconPath = "https://localhost:7046/img/apple-general.png",
                    TransactionName = "Payment",
                    UserFrom = "JPMorgan",
                    UserOwnerId = 1,
                    TransactionStatus = Enums.TransactionStatus.Success,
                    TransactionType = Enums.TransactionType.Credit,
                    TransactionAmount = 14.06m,     
                },
                new EfTransactionModel
                {
                    TransactionId = 3,
                    TransactionDate = DateTime.Now,
                    TransactionDescription = "Card Number Used",
                    IconPath = "https://localhost:7046/img/apple.png",
                    TransactionName = "Apple",
                    UserFrom = string.Empty,
                    UserOwnerId = 1,
                    TransactionStatus = Enums.TransactionStatus.Success,
                    TransactionType = Enums.TransactionType.Credit,
                    TransactionAmount = 14.06m,     
                },
                new EfTransactionModel
                {
                    TransactionId = 4,
                    TransactionDate = DateTime.Now.AddDays(-1),
                    TransactionDescription = "Chase Bank Natio...",
                    IconPath = "https://localhost:7046/img/apple-general.png",
                    TransactionName = "Payment",
                    UserFrom = "JPMorgan",
                    UserOwnerId = 1,
                    TransactionStatus = Enums.TransactionStatus.Success,
                    TransactionType = Enums.TransactionType.Credit,
                    TransactionAmount = 14.06m,     
                },
                new EfTransactionModel
                {
                    TransactionId = 5,
                    TransactionDate = DateTime.Now.AddDays(-1),
                    TransactionDescription = "Chase Bank Natio...",
                    IconPath = "https://localhost:7046/img/apple-general.png",
                    TransactionName = "Payment",
                    UserFrom = "JPMorgan",
                    UserOwnerId = 1,
                    TransactionStatus = Enums.TransactionStatus.Success,
                    TransactionType = Enums.TransactionType.Credit,
                    TransactionAmount = 14.06m,     
                },
                new EfTransactionModel
                {
                    TransactionId = 6,
                    TransactionDate = DateTime.Now.AddYears(-1),
                    TransactionDescription = "Round Rock, Tx",
                    IconPath = "https://localhost:7046/img/ikea.png",
                    TransactionName = "IKEA",
                    UserFrom =  string.Empty,
                    UserOwnerId = 1,
                    TransactionStatus = Enums.TransactionStatus.Success,
                    TransactionType = Enums.TransactionType.Credit,
                    TransactionAmount = 14.06m,     
                },
                new EfTransactionModel
                {
                    TransactionId = 7,
                    TransactionDate = DateTime.Now.AddDays(-1),
                    TransactionDescription = "Cedar Park, TX",
                    IconPath = "https://localhost:7046/img/target.png",
                    TransactionName = "Target",
                    UserFrom =  string.Empty,
                    UserOwnerId = 1,
                    TransactionStatus = Enums.TransactionStatus.Success,
                    TransactionType = Enums.TransactionType.Credit,
                    TransactionAmount = 14.06m,     
                },
                new EfTransactionModel
                {
                    TransactionId = 8,
                    TransactionDate = DateTime.Now.AddDays(-1),
                    TransactionDescription = "Card Number Used",
                    IconPath = "https://localhost:7046/img/apple-general.png",
                    TransactionName = "Apple",
                    UserFrom = "Diana",
                    UserOwnerId = 1,
                    TransactionStatus = Enums.TransactionStatus.Success,
                    TransactionType = Enums.TransactionType.Credit,
                    TransactionAmount = 14.06m,     
                },
                new EfTransactionModel
                {
                    TransactionId = 9,
                    TransactionDate = DateTime.Now.AddDays(-1),
                    TransactionDescription = "Card Number Used",
                    IconPath = "https://localhost:7046/img/apple-general.png",
                    TransactionName = "Apple",
                    UserFrom = "Diana",
                    UserOwnerId = 1,
                    TransactionStatus = Enums.TransactionStatus.Success,
                    TransactionType = Enums.TransactionType.Credit,
                    TransactionAmount = 14.06m,     
                },
                new EfTransactionModel
                {
                    TransactionId = 10,
                    TransactionDate = DateTime.Now.AddDays(-1),
                    TransactionDescription = "Card Number Used",
                    IconPath = "https://localhost:7046/img/apple-general.png",
                    TransactionName = "Apple",
                    UserFrom = "Diana",
                    UserOwnerId = 1,
                    TransactionStatus = Enums.TransactionStatus.Success,
                    TransactionType = Enums.TransactionType.Credit,
                    TransactionAmount = 14.06m,     
                },

            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(_connectionString);
        }
        public DbSet<EfTransactionModel> Transaction { get; set; }
        public DbSet<EFUserModel> User { get; set; }
    }
}
