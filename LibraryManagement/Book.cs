namespace LibraryManagement
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public bool IsAvailable { get; private set; } = true;

        //create a new book
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public bool Borrow()
        {
            if (!IsAvailable)
            {
                return false; // Book is not available
            }
            IsAvailable = false;
            return true;
        }

        //return the book (makes it available again)
        public void Return()
        {
            IsAvailable = true;
        }

        //show a readable description of the book
        public override string ToString()
        {
            return $"{Title} by {Author} | Available: {IsAvailable}";
        }
    }
}
