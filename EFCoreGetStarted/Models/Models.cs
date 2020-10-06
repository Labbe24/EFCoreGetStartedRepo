using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EFCoreGetStarted.Models
{
    class Models
    {
    }

    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PublishDate { get; set; }
        public int Price { get; set; }
        public string Imgurl { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
    }

    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Imgurl { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
    }

    public class BookAuthor
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }

    public class BookAuthorContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Book - Author (many to many relationship)
            modelBuilder.Entity<BookAuthor>()
                .HasKey(p => new {p.BookId, p.AuthorId});
            modelBuilder.Entity<BookAuthor>()
                .HasOne(ba => ba.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(ba => ba.BookId);
            modelBuilder.Entity<BookAuthor>()
                .HasOne(ba => ba.Author)
                .WithMany(a => a.BookAuthors)
                .HasForeignKey(ba => ba.AuthorId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source = 192.168.211.134,1433;Database=BookSystem;User ID=SA;Password=Password1!;");
        
    }

    public class Review
    {

    }

    public class PriceOffer
    {

    }
}
