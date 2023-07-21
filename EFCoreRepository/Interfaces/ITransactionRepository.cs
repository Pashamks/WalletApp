using EFCoreRepository.Models;

namespace EFCoreRepository.Interfaces
{
    public interface ITransactionRepository
    {
        Task<EfTransactionModel> TransactionDetailsById(int id);
        Task<List<EfTransactionModel>> TransactionsByUserId(int id);
    }
}
