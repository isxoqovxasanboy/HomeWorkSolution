namespace CL02.Models
{
    public abstract class Card
    {
        private Guid? _number;
        private string? _holderName = string.Empty;
        private decimal? _balance = default;

        public Guid? Number { get => this._number; set => this._number = value; }

        public string? HolderName { get => this._holderName; set => this._holderName = value; }

        public decimal? Balance { get => this._balance; set => this._balance = value; }

        public Card(Guid number, string holderName, decimal balance)
        {
            this.Number = number;
            this.HolderName = holderName;
            this.Balance = balance;

        }


        public abstract bool Pay(decimal amount);

        public override string ToString()
        {
            return $"Foydalanuvchi Id raqami {this.Number}" +
                $"\nFoydalanuvchi Ismi {this.HolderName}";
        }

    }
}
