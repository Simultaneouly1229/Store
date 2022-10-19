using System.Text.RegularExpressions;

namespace Store
{
    public class Book
    {
        public int Id { get; }
        public string Isbn { get; }
        public string Author { get; }
        public string Title { get; }

        public Book(int id, string isbn, string author, string title)
        {
            Id = id;
            Title = title;
            Isbn = isbn;
            Author = author;
        }

        internal static bool IsIsbn(string supposedIsbn)
        {
            if (string.IsNullOrEmpty(supposedIsbn))
            {
                return false;
            }

            supposedIsbn = supposedIsbn.Replace("-", "")
                                       .Replace(" ", "")
                                       .ToUpper();

            return Regex.IsMatch(supposedIsbn, @"^ISBN\d{10}(\d{3})?$");
        }
    }
}