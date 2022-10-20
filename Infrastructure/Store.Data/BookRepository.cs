using System;
using System.Linq;
using Store;

namespace Store.Data
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1,"ISBN 12312-12312", "D. Knuth", "Art Of Programming", "Volumes 1–5 are intended to represent the central core of computer programming for sequential machines.", 7.19m),
            new Book(2,"ISBN 12312-12311","M. Fowler", "Refactoring", "Fully Revised and Updated–Includes New Refactorings and Code Examples ", 12.45m),
            new Book(3,"ISBN 12312-12313","Kernighan", "C Programming Language", "the latter of whom originally designed and implemented the language, as well as co-designed the Unix operating system with which development of the language was closely intertwined.", 14.98m),
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

        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }
    }
}
