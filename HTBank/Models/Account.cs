namespace HTBank.Models
{
    //    ** Account** nomli class yarating uni** User** sinfiga voris qiling.Unga quyidagi property larni qo’shing

    //- **AccountNumber** - Account Id raqami (hisob raqam)
    //- **CreatedDate** - akkaunt yaratilgan sana
    //- **Cards** - akkountga qo’shilgan kartalar ro’yxati
    //- **TotalBalance - umumiy balance**
    /// <inheritdoc/>
    /// <seealso cref="HTBank.Models.User"/>
    public class Account : User
    {
        private readonly List<Card> cards = new List<Card>();

        public int AccountNumber { get => base.Id; set => base.Id = value; }

        public List<Card> GetCards() => cards;

        public DateTime CreatedDate { get; init; }

        public decimal TotalBalance { get => cards.Sum(totalBalance => totalBalance.Balance); }


    }
}
