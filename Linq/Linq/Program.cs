

using System;
using System.Linq;

namespace Linq

{
    class Program
    {
        static public bool SpecialMethod(Book b)
        {
            if (b.Price > 10) return true;
            else return false;
        }
        static void Main(string[] args)
        {

            var books = new BookRepo().GetBooks();

            var cheapo = books.Where(b => b.Price > 10);

            Func<Book, bool> check = Book => SpecialMethod(Book);

            var cheapo1 = books.Where(check);

            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine("********** var cheapo =  books.Where(b => b.Price < 10 );");
            foreach (var b in cheapo)
            {
                Console.WriteLine("Name: " + b.Title + " Price: " + b.Price);
            }

            Console.WriteLine(@"**********Func<Book, bool> check = Book => SpecialMethod(Book);
            var cheapo1 = books.Where(check);");
            foreach (var b in cheapo1)
            {
                Console.WriteLine("Name: " + b.Title + " Price: " + b.Price);
            }


        }



    }
}
