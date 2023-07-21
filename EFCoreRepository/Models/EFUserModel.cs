
using System.ComponentModel.DataAnnotations;

namespace EFCoreRepository.Models
{
    public class EFUserModel
    {
        [Key]
        public int UserId { get; set; }
        public string FullName { get; set; }
        public decimal CardBalance { get; set; }
    }
}
