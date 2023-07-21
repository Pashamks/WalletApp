using WalletBusinessLogic.Models;

namespace WalletBusinessLogic.Interfaces
{
    public interface ITransactionManager
    {
        Task<TransactionModel> TransactionDetailsById(int id);
        Task<List<TransactionModel>> TransactionsByUserId(int id);
    }
}
