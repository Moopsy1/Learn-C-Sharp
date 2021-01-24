

using System.Collections.Generic;
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

            var Annon_cheapBooks = books.Where(B => B.Price > 5);

            Func<Book, bool> check = Book => Book.Price > 5;
            var Delegate_cheapBooks = books.Where(check);

            Console.WriteLine("*******************");
            var Annon_sortedBooks = books.OrderBy(T => T.Title);

            Console.WriteLine("*******************");
            Func<Book, string> order = Book => Book.Title;
            var Delegate_sortedBooks = books.OrderBy(order);


            //LINQ Extention Methods
            var BookList = books
                                .Where(Book => Book.Price > 5)
                                .OrderBy(Book => Book.Title)
                                .Select(Book => Book.Title);


            //LINQ Query operators
            var BookList2 = from b in books
                            where b.Price > 5
                            orderby b.Title
                            select (b.Title, b.Price);
            
            var singleBook  = books.Single(Book => Book.Title == "Example book name");

            var firstBook = books.First(Book => Book.Title == "Example book name");
            var lastBook = books.Last(Book => Book.Title == "Example book name");

            var BookList3 = books.Skip(2).Take(3);

            var count = books.Count();

            var Total = books.Sum(Book => Book.Price);

            var Average = books.Average(Book => Book.Price);

            













        }




    }
}
