
using EFCoreRepository.Enums;

namespace WalletBusinessLogic.Models
{
    public class TransactionModel
    {
        public TransactionType TransactionType { get; set; }
        public decimal TransactionAmount { get; set; }
        public string TransactionName { get; set; }
        public string? TransactionDescription { get; set; }
        public string TransactionDate { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
        public string? UserFrom { get; set; }
        public string? IconPath { get; set; }
    }
}
