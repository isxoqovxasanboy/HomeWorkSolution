namespace Cls01.Models
{
    public class Person
    {
        private string _name = string.Empty;
        private int _age = default;

        public string Name
        {
            get => _name;
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("Argument null");
                }
                else
                {
                    _name = value;
                }
            }
        }
        public int Age { get => _age; set => _age = value; }

        public Person()
        {
            Age = default;
            Name = "User";
        }

        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}";
        }


    }
}
