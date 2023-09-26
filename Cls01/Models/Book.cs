namespace Cls01.Models
{
    public class Book
    {
        private string? _title;
        private string? _author;
        private Guid _isbn;

        public string Title { get => _title; set => _title = value; }
        public string Author { get => _author; set => _author = value; }

        public Guid Isbn { get => _isbn; set => _isbn = value; }

        public Book(string title, string author, Guid isbn)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
        }

        public override string ToString()
        {
            return $"Books name: {Title}\n" +
                   $"Book author:{Author}\n" +
                   $"Book Isbn: {Isbn} ";
        }



    }
}
