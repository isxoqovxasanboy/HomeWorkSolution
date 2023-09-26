using Cls01.Models;

namespace Cls01.Base
{
    public static class BaseBooks
    {
        private static Book[] books = new Book[10];
        private static int _count = 0;

        //public BaseBooks()
        //{

        //}
        public static void AddBook(Book book)
        {
            if (_count == books.Length)
            {
                Book[] newBook = new Book[books.Length * 2];

                for (int index = 0; index < books.Length; index++)
                {
                    newBook[index] = books[index];
                }
                books = newBook;
            }
            books[_count] = book;
            _count++;
        }

        public static void RemoveBook(string bookName)
        {
            for (int index = 0; index < books.Length; index++)
            {
                if (books[index] != null)
                {
                    if (books[index].Title == bookName)
                    {
                        for (int j = index; j < books.Length - 1; j++)
                        {
                            books[j] = books[j + 1];
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            _count--;

        }


        public static void BooksPrint()
        {
            for (int index = default; index < books.Length; index++)
            {
                if (books[index] == null)
                {
                    break;
                }
                Console.WriteLine($"{index + 1}.\n{books[index]}");
                Console.WriteLine();
            }
        }

    }
}
