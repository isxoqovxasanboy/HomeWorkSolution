namespace N14Practic.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string? Country { get; set; }

        public string? Street { get; set; }

        public int? HomeNumber { get; set; }

        public Address(int id, string country, string street, int homeNumber)
        {
            Id = id;
            Country = country;
            Street = street;
            HomeNumber = homeNumber;
        }
        public Address()
        {
            Id = Id;
            Country = null;
            Street = null;
            HomeNumber = default(int);
        }

    }
}
