using HTBank.Models;

namespace HTBank.Services.IServices
{
    //    ** IAccountPayments** nomli interface yarating va unga quyidagi method e’lonlarini qo’shing:

    //- Withdraw(Account account, Card card, double ammount) - akkountdagi kartadan pul yechish
    //- Deposit(Account account, Card card, double ammount) - akkountdagi kartaga pul to’lash
    //- CreateCard(Account account, Card card) - akkount uchun yangi karta ochish
    //- RemoveCard(Account account, Card card) - akkountdagi kartani o’chirish
    public interface IAccountPayments
    {
        /// <summary>
        /// withdrawal of money from the account card
        /// </summary>
        /// <param name="account"></param>
        /// <param name="card"></param>
        /// <param name="ammount"></param>
        void Withdraw(Account account, Card card, decimal ammount);

        /// <summary>
        /// payment to the card in the account
        /// </summary>
        /// <param name="account"></param>
        /// <param name="card"></param>
        /// <param name="ammount"></param>
        void Deposit(Account account, Card card, double ammount);

        /// <summary>
        /// opening a new card for the account
        /// </summary>
        /// <param name="account"></param>
        /// <param name="card"></param>
        void CreateCard(Account account, Card card);
        /// <summary>
        /// Removing a card for the account;
        /// </summary>
        /// <param name="account"></param>
        /// <param name="card"></param>
        void RemoveCard(Account account, Card card);
    }
}
