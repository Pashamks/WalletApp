using EFCoreRepository.Interfaces;
using EFCoreRepository.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreRepository.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly EFCoreDbContext _dbContext;
        public TransactionRepository(EFCoreDbContext context)
        {
            _dbContext = context;
        }
        public async Task<EfTransactionModel> TransactionDetailsById(int id) =>
            await _dbContext.Transaction.FirstAsync(x => x.TransactionId == id);

        public async Task<List<EfTransactionModel>> TransactionsByUserId(int id) =>
            await _dbContext.Transaction.Where(x => x.UserOwnerId == id).ToListAsync();
    }
}
