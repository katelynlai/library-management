using LibraryManagement;

// Create a library
var library = new Library();

// Create some books
var book1 = new Book("Pride and Prejudice", "Jane Austen");
var book2 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
var book3 = new Book("To Kill a Mockingbird", "Harper Lee");

// Add books to the library
library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);

// List all books
Console.WriteLine("All Books in Library:");
foreach (var book in library.GetAllBooks())
{
    Console.WriteLine($"- {book.Title} by {book.Author} | Available: {book.IsAvailable}");
}

// Search by title
var searchByTitle = library.GetBookByTitle("Pride and Prejudice");
Console.WriteLine($"Search by Title 'Pride and Prejudice': {(searchByTitle != null ? "Found!" : "Not Found")}");

// Search by author
var searchByAuthor = library.GetBookByAuthor("Jane Austen");
Console.WriteLine($"Search by Author 'Jane Austen': {(searchByAuthor != null ? "Found!" : "Not Found")}");

// Remove a book
library.RemoveBook(book3);
Console.WriteLine($"Removed '{book3.Title}' from the library");

// Create patrons
var patron1 = new Patron("Katelyn");
var patron2 = new Patron("Bob");

// Add patrons to library
library.AddPatron(patron1);
library.AddPatron(patron2);

// Borrow a book
Console.WriteLine($"Borrowing '{book1.Title}' for {patron1}...");
if (library.BorrowBook(patron1, book1))
    Console.WriteLine($"{patron1} successfully borrowed {book1.Title}");
else
    Console.WriteLine($"Failed to borrow {book1.Title}.");

// Try borrowing the same book for Bob (should fail)
Console.WriteLine($"{patron2} tries to borrow '{book1.Title}'...");
if (library.BorrowBook(patron2, book1))
    Console.WriteLine($"{patron2} successfully borrowed {book1.Title}");
else
    Console.WriteLine($"Sorry, {book1.Title} is not available");

// Return the book
Console.WriteLine($"{patron1} returns '{book1.Title}'...");
if (library.ReturnBook(patron1, book1))
    Console.WriteLine($"{book1.Title} is now available again");

// Remove a patron
library.RemovePatron(patron2);
Console.WriteLine($"Removed patron {patron2}");

// Final book list
Console.WriteLine($"Final Books in Library:");
foreach (var book in library.GetAllBooks())
{
    Console.WriteLine($"- {book.Title} by {book.Author} | Available: {book.IsAvailable}");
}
