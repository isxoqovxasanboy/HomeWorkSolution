namespace HTBank.Models
{

    public class User
    {
        protected int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime BrithDay { get; set; }

        public string? PhoneNumber { get; set; }
    }
}
