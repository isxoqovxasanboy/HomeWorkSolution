using N14Practic.Enum;

namespace N14Practic.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public double Salary { get; set; }

        public string? Email { get; set; }

        public Gender GendersEmployee { get; set; }

        public Department DepartmentEmployee { get; set; }

        public Address? AddressEmployee { get; set; }



    }
}
