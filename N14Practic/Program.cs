using N14Practic.Enum;
using N14Practic.Models;
using N14Practic.Repositories;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Typle issuess
        //List<Tuple<int, string, string, string>> people = new();

        //people.Add(new Tuple<int, string, string, string>(2, "Jane", "Smith", "666-666-6666"));
        //people.Add(new Tuple<int, string, string, string>(3, "Alice", "Johnson", "777-777-7777"));
        //people.Add(new Tuple<int, string, string, string>(9, "Michael", "Davis", "111-111-1111"));
        //people.Add(new Tuple<int, string, string, string>(1, "John", "Doe", "555-555-5555"));
        //people.Add(new Tuple<int, string, string, string>(6, "Alice", "Johnson", "777-777-7777"));
        //people.Add(new Tuple<int, string, string, string>(11, "William", "Jones", "333-333-3333"));
        //people.Add(new Tuple<int, string, string, string>(4, "John", "Doe", "555-555-5555"));
        //people.Add(new Tuple<int, string, string, string>(13, "James", "Garcia", "123-456-7890"));
        //people.Add(new Tuple<int, string, string, string>(7, "Robert", "Williams", "888-888-8888"));
        //people.Add(new Tuple<int, string, string, string>(10, "Olivia", "Wilson", "222-222-2222"));
        //people.Add(new Tuple<int, string, string, string>(8, "Emily", "Brown", "999-999-9999"));
        //people.Add(new(0, "Hasanboy", "Isxoqov", "+998936054827"));
        //people.Add(new Tuple<int, string, string, string>(5, "Jane", "Smith", "666-666-6666"));
        //people.Add(new Tuple<int, string, string, string>(12, "Ava", "Miller", "444-444-4444"));
        // You can continue adding more tuples as needed


        //for (int indexA = 0; indexA < people.Count; indexA++)
        //{
        //    for (int indexB = 0; indexB < people.Count; indexB++)
        //    {
        //        if (people[indexA].Item1 < people[indexB].Item1)
        //        {
        //            var temp = people[indexA];
        //            people[indexA] = people[indexB];
        //            people[indexB] = temp;
        //        }
        //    }
        //}

        //foreach (var item in people)
        //{
        //    Console.WriteLine($"Id : {item.Item1} " +
        //        $"Firt name: {item.Item2} Last name: {item.Item3} " +
        //        $"Phone number: {item.Item4}");
        //}
        #endregion
        #region Created Employees

        BaseRepository baseRepository = new BaseRepository();
        int IdNumber = 0;
        Employee employee = new Employee();
        employee.Id = IdNumber;
        employee.FirstName = "Hasanboy";
        employee.LastName = "Isxoqov";
        employee.Email = "IsxoqovBoy@gmail.com";
        employee.DepartmentEmployee = Department.Adminstration;
        employee.GendersEmployee = Gender.Male;
        employee.AddressEmployee = new Address(IdNumber, "Uzbekistan", "Toshkent", 122412);

        Employee employee0 = new Employee()
        {
            Id = ++IdNumber,
            FirstName = "Alice",
            LastName = "Johnson",
            Email = "alice.johnson@example.com",
            DepartmentEmployee = Department.Economy,
            GendersEmployee = Gender.Female,
            AddressEmployee = new Address
            {
                Id = 21,
                Street = "123 Oak St",
                Country = "Sampleville",
                HomeNumber = 98765
            }
        };
        Employee employee1 = new Employee()
        {
            Id = ++IdNumber,
            FirstName = "Bob",
            LastName = "Smith",
            Email = "bob.smith@example.com",
            DepartmentEmployee = Department.Marketing,
            GendersEmployee = Gender.Male,
            AddressEmployee = new Address
            {
                Street = "456 Elm St",
                Country = "Techtown",
                HomeNumber = 54321
            }
        };
        Employee employee2 = new Employee()
        {
            Id = ++IdNumber,
            FirstName = "Eva",
            LastName = "Williams",
            Email = "eva.williams@example.com",
            DepartmentEmployee = Department.Economy,
            GendersEmployee = Gender.Female,
            AddressEmployee = new Address
            {
                Street = "789 Maple St",
                Country = "Marketingtown",
                HomeNumber = 12345
            }
        };
        Employee employee3 = new Employee()
        {
            Id = ++IdNumber,
            FirstName = "David",
            LastName = "Brown",
            Email = "david.brown@example.com",
            DepartmentEmployee = Department.Education,
            GendersEmployee = Gender.Male,
            AddressEmployee = new Address
            {
                Street = "321 Pine St",
                Country = "Financetown",
                HomeNumber = 67890
            }
        };
        Employee employee4 = new Employee()
        {
            Id = ++IdNumber,
            FirstName = "Olivia",
            LastName = "Martinez",
            Email = "olivia.martinez@example.com",
            DepartmentEmployee = Department.Adminstration,
            GendersEmployee = Gender.Female,
            AddressEmployee = new Address
            {
                Street = "654 Cedar St",
                Country = "Admintown",
                HomeNumber = 13579
            }
        };
        Employee employee5 = new Employee()
        {
            Id = ++IdNumber,
            FirstName = "Michael",
            LastName = "Lee",
            Email = "michael.lee@example.com",
            DepartmentEmployee = Department.Security,
            GendersEmployee = Gender.Male,
            AddressEmployee = new Address
            {
                Street = "987 Birch St",
                Country = "Techville",
                HomeNumber = 24680
            }
        };
        Employee employee6 = new Employee()
        {
            Id = ++IdNumber,
            FirstName = "Sophia",
            LastName = "Garcia",
            Email = "sophia.garcia@example.com",
            DepartmentEmployee = Department.Marketing,
            GendersEmployee = Gender.Female,
            AddressEmployee = new Address
            {
                Street = "456 Oak St",
                Country = "Marketville",
                HomeNumber = 86420
            }
        };
        Employee employee7 = new Employee()
        {
            Id = ++IdNumber,
            FirstName = "James",
            LastName = "Taylor",
            Email = "james.taylor@example.com",
            DepartmentEmployee = Department.Adminstration,
            GendersEmployee = Gender.Male,
            AddressEmployee = new Address
            {
                Street = "753 Pine St",
                Country = "Adminville",
                HomeNumber = 7531
            }
        };
        Employee employee8 = new Employee()
        {
            Id = ++IdNumber,
            FirstName = "Emily",
            LastName = "Anderson",
            Email = "emily.anderson@example.com",
            DepartmentEmployee = Department.Security,
            GendersEmployee = Gender.Female,
            AddressEmployee = new Address
            {
                Street = "159 Maple St",
                Country = "Financeville",
                HomeNumber = 35791
            }
        };
        Employee employee9 = new Employee()
        {
            Id = ++IdNumber,
            FirstName = "William",
            LastName = "Clark",
            Email = "william.clark@example.com",
            DepartmentEmployee = Department.Economy,
            GendersEmployee = Gender.Male,
            AddressEmployee = new Address
            {
                Street = "852 Cedar St",
                Country = "Techtown",
                HomeNumber = 12340
            }
        };
        #endregion
        #region Added Base Repository
        baseRepository.Create(employee);
        baseRepository.Create(employee0);
        baseRepository.Create(employee1);
        baseRepository.Create(employee2);
        baseRepository.Create(employee3);
        baseRepository.Create(employee4);
        baseRepository.Create(employee5);
        baseRepository.Create(employee6);
        baseRepository.Create(employee7);
        baseRepository.Create(employee8);
        baseRepository.Create(employee9);
        #endregion

        //baseRepository.Delete(0);

        //var empi = baseRepository.GetInfoByEmail("IsxoqovBo@gmail.com");

    }
}