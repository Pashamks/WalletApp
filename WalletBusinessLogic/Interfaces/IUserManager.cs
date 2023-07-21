
using WalletBusinessLogic.Models;

namespace WalletBusinessLogic.Interfaces
{
    public interface IUserManager
    {
        Task<CardBalanceModel> CardBalance();
        Task<PaymentDueModel> PaymentDue();

    }
}
