namespace LibraryManagement
{
    public class Library
    {
        //lists to hold books and patrons
        public List<Book> Books { get; } = new List<Book>();
        public List<Patron> Patrons { get; } = new List<Patron>();

        //add or remove books
        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }

        //search for a book by author or title
        public Book? GetBookByAuthor(string author)
        {
            foreach (var book in Books)
            {
                if (book.Author == author)
                    return book;
            }
            return null; //not found
        }

        public Book? GetBookByTitle(string title)
        {
            foreach (var book in Books)
            {
                if (book.Title == title)
                    return book;
            }
            return null; //not found
        }

        //get all books
        public List<Book> GetAllBooks()
        {
            return Books;
        }

        //add or remove patrons
        public void AddPatron(Patron patron)
        {
            Patrons.Add(patron);
        }

        public void RemovePatron(Patron patron)
        {
            Patrons.Remove(patron);
        }

        //borrow or return a book
        public bool BorrowBook(Patron patron, Book book)
        {
            return patron.BorrowBook(book);
        }

        public bool ReturnBook(Patron patron, Book book)
        {
            return patron.ReturnBook(book);
        }
    }
}
