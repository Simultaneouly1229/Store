using System;
using System.Linq;
using Store;

namespace Store.Data
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1,"ISBN 12312-12312", "D. Knut", "Art Of Programming"),
            new Book(2,"ISBN 12312-12311","M. Fowler", "Refactoring"),
            new Book(3,"ISBN 12312-12313","Kernighan", "C Programming Language"),
        };

        public Book[] GetBooksByIsbn(string isbn)
        {
            return books.Where(x => x.Isbn == isbn).ToArray();
        }

        public Book[] GetBooksByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Title.Contains(query) 
                                    || book.Author.Contains(query))
                                           .ToArray();
        }
    }
}
