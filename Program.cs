using System;
using System.Collections.Generic;

// Make a new console application (remember the -f net5.0 flag when running dotnet new console
// You can remove all the code in Program.cs except using System;
// At the bottom of the Program file, define a Book type with some properties you might expect a book to have (Author, title, publishdate, number of pages, whatever you like...). You can use the example at the bottom of chapter 9 as a guide if you're still learning the syntax.
// at the top of the file (after using System;), create three instances of your Book class using the new keyword. You can use the object initialize (the {}) to add values for each of those instances (for example {Title = "20,000 Leagues Under the Sea"}
// Add a constructor that allows you to set the properties on object creation.
// You should now have compiler errors. What are your options for fixing the errors? Come up with at least two options, and then pick one solution and implement it.
// Create an empty List of Book s.
// Use the Add method to add your three instances to the list.
// Iterate over the list and print "<Title> - by <Author>" or something like that for each iteration (react to this post with :book: when you've finished this step)
// Bonus: Write a get-only Property for the class to create the string in Step 8 for you. The property can be called DisplayName
// Bonus: Use your newly created property in the iteration you wrote in step 8 (react with :books: if you finish this step)

Book harryPotter1 = new Book("JK Rowling", "Harry Potter and the Sorcerer's Stone", 1997, 223);
Book hankTheCowDog1 = new Book("John R Erickson", "The Original Adventures of Hank the Cowdog", 1980, 144);
Book soldierX = new Book("Don L Wulffson", "Soldier X", 2001, 227);

List<Book> books = new List<Book>();

books.Add(harryPotter1);
books.Add(hankTheCowDog1);
books.Add(soldierX);

foreach (Book book in books)
{
    Console.WriteLine($"{book.DisplayName}");
}

Library bookLibrary = new Library("bookLibrary");
bookLibrary.AddBook(harryPotter1);
bookLibrary.AddBook(hankTheCowDog1);
bookLibrary.AddBook(soldierX);

bookLibrary.ListLibrary();

public class Book
{

    public Book(string author, string title, int publishDate, int numberOfPages)
    {
        Author = author;
        Title = title;
        PublishDate = publishDate;
        NumberOfPages = numberOfPages;
    }

    public string Author { get; set; }
    public string Title { get; set; }
    public int PublishDate { get; set; }
    public int NumberOfPages { get; set; }

    public string DisplayName
    {
        get
        {
            return $"{Title} by {Author} was originally published in {PublishDate} and is {NumberOfPages} long.";
        }
    }
}

public class Library
{
    public string Name { get; set; }
    public Library(string name)
    {
        Name = name;
    }

    private List<Book> _privateBookList = new List<Book>();

    public void AddBook(Book book)
    {
        _privateBookList.Add(book);
    }

    public void ListLibrary()
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("ListLibrary Results:");

        foreach (Book book in _privateBookList)
        {
            Console.WriteLine($"{book.DisplayName}");
        }
    }
}

// 8-25 Instructions
// Open the Book app that you made for yesterday's lightning exercise
// Create a new class called Library (you can put it in Program.cs under the Book class). It should have a Name property
// Add a private field which is  a List of Books. Give it a good name for a private field.
// Create a method in the Library class called AddBook that takes a Book parameter, and adds the book to the book list
// Create another method called ListLibrary that iterates through the library's books and prints their DisplayName  (see the bonus from yesterday)
// create a library using the Library class, and add books to it using the AddBook and print the library to the console using the ListLibrary method