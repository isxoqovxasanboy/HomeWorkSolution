
using HTBank.Models;

namespace HTBank.Services.IServices
{
    //    IAccountSettings nomli interface yarating va unga quyidagi method e’lonlarini qo’shing:

    //- CreateAccount(Account account) - yangi akkaunt qo’shish
    //- UpdateAccount(Account account) - mavjud bankni tahrirlash
    //- RemoveAccount(Account account) - bankni o’chirish
    //- GetAllAccounts() - barcha banklar ro’yxatini qaytarish
    public interface IAccountSettings
    {
        /// <summary>
        /// Adding a new account
        /// </summary>
        /// <param name="account"></param>
        void CreateAccount(Account account);

        /// <summary>
        /// Update a current account
        /// </summary>
        /// <param name="account"></param>
        void UpdateAccount(Account account);

        /// <summary>
        /// Remove a current account
        /// </summary>
        /// <param name="account"></param>
        void RemoveAccount(Account account);

        /// <summary>
        /// Return All accounts
        /// </summary>
        void GetAllAccounts();

    }
}
