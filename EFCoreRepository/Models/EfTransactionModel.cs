using EFCoreRepository.Enums;

namespace EFCoreRepository.Models
{
    public class EfTransactionModel
    {
        public int TransactionId { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal TransactionAmount { get; set; }
        public string TransactionName { get; set; }

        public string? TransactionDescription { get; set; }
        public DateTime TransactionDate { get; set; } 
        public TransactionStatus TransactionStatus { get; set; } 
    }
}
