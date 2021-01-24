using System.Collections.Generic;



namespace Linq
{
    public class BookRepo
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>{
                new Book() {Title = "ADO.NET Step by Step", Price = 6.2f},
                new Book() {Title = "Harry Potter and the Two Mysterious things", Price = 6.5f},
                new Book() {Title = "Example book name", Price = 20.2f},
                new Book() {Title = "Book 5 of 4", Price = 45.2f},
                new Book() {Title = "The answer to life and everything", Price = 9.2f},
                new Book() {Title = "Book of short stories of books of shorter stories", Price = 42.2f},
            };

        }
    }
}