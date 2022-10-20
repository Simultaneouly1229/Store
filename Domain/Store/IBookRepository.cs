using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public interface IBookRepository
    {
        Book[] GetBooksByIsbn(string isbn);

        Book[] GetBooksByTitleOrAuthor(string titleOrAuthor);

        Book GetById(int id);
    }
}
