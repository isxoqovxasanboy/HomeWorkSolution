namespace HTBank.Models
{
    //    ** Card** nomli class yarating va unga quyidagi property larni qo’shing

    //- ** Number** - Account Id raqami
    //- ** Holder -** ismi
    //- ** ValidDate -** ismi
    //- ** Type** - karta turi: (enum) uzcard, humo, visa, master, union
    //- ** Balance** - familiyasi
    public class Card
    {
        private decimal _balance = default;
        public int Number { get; set; }

        public string? Holder { get; set; }

        public DateTime ValidtyDate { get; set; }

        public CardType TypeCard { get; set; }
        public decimal Balance { get => _balance; set => _balance = value; }
    }
}
