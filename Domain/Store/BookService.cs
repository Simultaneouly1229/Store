using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class BookService
    {
        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;  
        }

        public Book[] GetBooksByQuery(string query)
        {
            if (Book.IsIsbn(query))
            {
                return bookRepository.GetBooksByIsbn(query);
            }
            else
            {
                return bookRepository.GetBooksByTitleOrAuthor(query);
            }
        }
    }
}
