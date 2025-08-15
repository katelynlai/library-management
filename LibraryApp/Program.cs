using LibraryManagement;

var library = new Library();

// Sample data
var book1 = new Book("Pride and Prejudice", "Jane Austen");
var book2 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
var book3 = new Book("To Kill a Mockingbird", "Harper Lee");

var patron1 = new Patron("Katelyn");
var patron2 = new Patron("Bob");

library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);

library.AddPatron(patron1);
library.AddPatron(patron2);

void PrintBooks(string header)
{
    Console.WriteLine($"\n===== {header} =====");
    foreach (var b in library.GetAllBooks())
        Console.WriteLine($"• {b.Title,-30} {b.Author,-20} Available: {b.IsAvailable}");
}

void Divider() => Console.WriteLine(new string('-', 50));

// Display all books
PrintBooks("All Books in Library");

// Search
Divider();
// Search by title
var foundBook = library.GetBookByTitle("Pride and Prejudice");

if (foundBook != null)
{
    Console.WriteLine("Search by Title 'Pride and Prejudice': Found");
}
else
{
    Console.WriteLine("Search by Title 'Pride and Prejudice': Not Found");
}

// Search by author
var foundByAuthor = library.GetBookByAuthor("Jane Austen");

if (foundByAuthor != null)
{
    Console.WriteLine("Search by Author 'Jane Austen': Found");
}
else
{
    Console.WriteLine("Search by Author 'Jane Austen': Not Found");
}

// Remove a book
Divider();
Console.WriteLine("Removing 'To Kill a Mockingbird'...");
library.RemoveBook(book3);
PrintBooks("After Removal");

// Borrow book
Divider();

// Patron 1 tries to borrow
Console.WriteLine($"Borrowing '{book1.Title}' for {patron1}...");
if (library.BorrowBook(patron1, book1))
{
    Console.WriteLine($"{patron1} successfully borrowed {book1.Title}");
}
else
{
    Console.WriteLine($"{patron1} could not borrow {book1.Title}");
}

// Patron 2 tries to borrow the same book
Console.WriteLine($"{patron2} tries to borrow '{book1.Title}'...");
if (library.BorrowBook(patron2, book1))
{
    Console.WriteLine($"{patron2} borrowed {book1.Title}");
}
else
{
    Console.WriteLine($"{book1.Title} is not available");
}

// Return book
Divider();
Console.WriteLine($"{patron1} returns '{book1.Title}'...");
library.ReturnBook(patron1, book1);
Console.WriteLine($"{book1.Title} is now available");

// Remove a patron
Divider();
Console.WriteLine($"Removing patron {patron2}...");
library.RemovePatron(patron2);

Divider();
// Final book list
PrintBooks("Final Books in Library");
