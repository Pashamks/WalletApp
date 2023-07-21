
using AutoMapper;
using EFCoreRepository.Interfaces;
using WalletBusinessLogic.Interfaces;
using WalletBusinessLogic.Models;

namespace WalletBusinessLogic.Managers
{
    public class TransactionManager : ITransactionManager
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IMapper _mapper;
        public TransactionManager(ITransactionRepository transactionRepository, IMapper mapper)
        {
            _transactionRepository = transactionRepository;
            _mapper = mapper;
        }
        public async Task<TransactionModel> TransactionDetailsById(int id) =>
            _mapper.Map<TransactionModel>(await _transactionRepository.TransactionDetailsById(id));

        public async Task<List<TransactionModel>> TransactionsByUserId(int id) =>
            _mapper.Map<List<TransactionModel>>(await _transactionRepository.TransactionsByUserId(id));
    }
}
