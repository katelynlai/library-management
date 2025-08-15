namespace LibraryManagement
{
    public class Patron
    {
        public string Name { get; }

        //list of books this patron has borrowed
        public List<Book> BorrowedBooks { get; } = new List<Book>();

        //create a new patron
        public Patron(string name)
        {
            Name = name;
        }

        //borrow a book
        public bool BorrowBook(Book book)
        {
            if (book.Borrow())
            {
                //if successful, add to borrowed books
                BorrowedBooks.Add(book);
                return true;
            }
            return false;
        }

        // Return a borrowed book
        public bool ReturnBook(Book book)
        {
            //remove book from borrowed list
            if (BorrowedBooks.Remove(book))
            {
                //mark the book as available
                book.Return();
                return true;
            }
            return false;
        }

        // Show patron's name when printing
        public override string ToString()
        {
            return Name;
        }
    }
}
