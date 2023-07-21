using EFCoreRepository.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreRepository.Models
{
    public class EfTransactionModel
    {
        [Key]
        public int TransactionId { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal TransactionAmount { get; set; }
        public string TransactionName { get; set; }
        public string? TransactionDescription { get; set; }
        public DateTime TransactionDate { get; set; } 
        public TransactionStatus TransactionStatus { get; set; }
        public string? UserFrom { get; set; }

        public string? IconPath { get; set; }
        [ForeignKey(nameof(User))]
        public int UserOwnerId { get; set; }
        public virtual EFUserModel User { get; set; }
    }
}
