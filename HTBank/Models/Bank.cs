
namespace HTBank.Models
{
    /// <summary>
    /// The bank.
    /// </summary>
    public class Bank
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public DateTime FoundedDate { get; set; }

        public string? Address { get; set; }

        public string? PhoneNumber { get; set; }

    }
}
