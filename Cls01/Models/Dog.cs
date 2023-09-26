namespace Cls01.Models
{
    public class Dog
    {
        private string _name = String.Empty;
        private string _breed = String.Empty;

        public string? Name { get; set; }
        public string? Breed { get; set; }

        public Dog(string nameDog, string breed)
        {
            Name = nameDog;
            Breed = breed;
        }



    }
}
