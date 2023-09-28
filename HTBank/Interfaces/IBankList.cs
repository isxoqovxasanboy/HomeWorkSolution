
using HTBank.Models;

namespace HTBank.Interfaces
{
    public interface IBankList
    {
        void CreateBank(Bank newBank);
        void UpdateBank(Bank bank);

        void RemoveBank(Bank bank);

        IEnumerable<Bank> GetAllBanks();

    }
}
