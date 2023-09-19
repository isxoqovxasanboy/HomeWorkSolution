namespace CL02.Models
{
    public class Humo : Card
    {
        public Humo(Guid number, string holderName, decimal balance)
            : base(number, holderName, balance)
        {

        }

        public override bool Pay(decimal amount)
        {
            if (base.Balance >= amount + (amount / 200))
            {
                base.Balance -= amount + (amount / 200);
                return true;
            }
            return false;
        }
    }
}
