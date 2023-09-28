using HTBank.Models;
using HTBank.Services.IServices;

namespace HTBank.Services
{
    /// <inheritdoc/>
    /// <seealso cref="HTBank.Services.IServices.IAccountSettings"/>
    /// <seealso cref="HTBank.Services.IServices.IAccountPayments"/>
    public class AccountSettings : IAccountSettings, IAccountPayments
    {
        public void CreateAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public void CreateCard(Account account, Card card)
        {
            throw new NotImplementedException();
        }

        public void Deposit(Account account, Card card, double ammount)
        {
            throw new NotImplementedException();
        }

        public void GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        public void RemoveAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public void RemoveCard(Account account, Card card)
        {
            throw new NotImplementedException();
        }

        public void UpdateAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(Account account, Card card, decimal ammount)
        {
            throw new NotImplementedException();
        }
    }
}
