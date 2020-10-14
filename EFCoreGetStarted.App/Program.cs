using System;
using System.Linq;
using EFCoreGetStarted.Models;

namespace EFCoreGetStarted.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var context = new BookAuthorContext())
            {
                Console.WriteLine("Insert book? Y/n");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.KeyChar == 'Y')
                {
                    Console.WriteLine("Input title: ");
                    string title = Console.ReadLine();

                    Book book = new Book()
                    {
                        Title = title
                    };

                    context.Add(book);
                    context.SaveChanges();
                }
                Console.WriteLine("Show all books? Y/n");
                consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.KeyChar == 'Y')
                {
                    foreach (var book in context.Books.ToList())
                    {
                        Console.WriteLine(book.Title);
                    }
                }
            }
        }
    }
}
