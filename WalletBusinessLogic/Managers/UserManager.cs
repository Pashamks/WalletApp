using WalletBusinessLogic.Interfaces;
using WalletBusinessLogic.Models;

namespace WalletBusinessLogic.Managers
{
    public class UserManager : IUserManager
    {
        const int LIMIT = 1500;

        public Task<CardBalanceModel> CardBalance()
        {
            var random = new Random();
            int value = random.Next(0, LIMIT);

            return Task.FromResult(new CardBalanceModel
            {
                CardBalance = value,
                Limit = $"$ {LIMIT - value} Available"
            });
        }

        public Task<PaymentDueModel> PaymentDue()
        {
            return Task.FromResult(new PaymentDueModel
            {
                Message = $"You've paid your {DateTime.Now.ToString("MMMM")}"
            });
        }
    }
}
