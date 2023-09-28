
using HTBank.Interfaces;

namespace HTBank.Models
{
    /// <inheritdoc/>
    /// <seealso cref="HTBank.Interfaces.IBankList"/>
    public class BankList : IBankList
    {
        private readonly List<Bank> banks = new List<Bank>();
        public int TotalCount { get => banks.Count; }
        public void CreateBank(Bank newBank)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bank> GetAllBanks()
        {
            throw new NotImplementedException();
        }

        public void RemoveBank(Bank bank)
        {
            throw new NotImplementedException();
        }

        public void UpdateBank(Bank bank)
        {
            throw new NotImplementedException();
        }
    }
}
