using System;
using System.Collections.Generic;
using System.Linq;
using EFCoreGetStarted.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreGetStarted.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var context = new BookAuthorContext())
            {
                Console.WriteLine("Insert book(b)?");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.KeyChar == 'b')
                {
                    Console.WriteLine("Input authors firstname: ");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Input authors lastname: ");
                    string lastname = Console.ReadLine();

                    Author author = new Author
                    {
                        FirstName = firstname,
                        LastName = lastname

                    };

                    BookAuthor bookAuthor = new BookAuthor
                    {
                        Author = author
                    };

                    Console.WriteLine("Input title: ");
                    string title = Console.ReadLine();

                    Book book = new Book()
                    {
                        Title = title,
                        BookAuthors = new List<BookAuthor>()
                    };
                    book.BookAuthors.Add(bookAuthor);
                    
                    context.Add(book);
                    context.Add(author);
                    context.SaveChanges();
                }

                Console.WriteLine("Show all books? Y/n");
                consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.KeyChar == 'Y')
                {
                    var books = context.Books
                        .Include(b => b.BookAuthors)
                        .ThenInclude(ba => ba.Author)
                        .ToList();

                    

                    foreach (var book in books)
                    {
                        Console.WriteLine("Title: {0}, Author: {1} {2}", book.Title, book.BookAuthors[0].Author.FirstName, book.BookAuthors[0].Author.LastName);
                    }
                    
                }
            }
        }
    }
}
