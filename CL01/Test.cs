using System.Text.RegularExpressions;

namespace CL01
{
    public class Test
    {
        private Regex _nameRegex = new Regex(" ");

        public Regex NameRegex { get; }

        public Test()
        {
            _nameRegex = new Regex(" ");
            NameRegex = new Regex(" ");

        }

        public void Testr()
        {
            _nameRegex = new Regex(" ");
        }

    }
}

