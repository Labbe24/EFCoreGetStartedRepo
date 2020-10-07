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
        public string Isbn10 { get; set; }
        [MaxLength(20)]
        public string Isbn13 { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PublishDate { get; set; }
        public int Price { get; set; }
        public string Imgurl { get; set; }
        public PriceOffer PriceOffer { get; set; }
        public int Pages { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
        public Author PrimaryAuthor { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Edition> Editions { get; set; }
        public Book NextInSeries { get; set; }
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

    public class Edition
    {
        public int EditionId { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public Review Review{ get; set; }
        public int ReviewId { get; set; }
    }

    public class Review
    {
        public int ReviewId { get; set; }
        public string VoteName { get; set; }
        public int NumStars { get; set; }
        public string Comment { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public string ReviewDate { get; set; }
        public List<Edition> Editions { get; set; }
        public List<Voter> Voters { get; set; }
    }

    public class PriceOffer
    {
        public int PriceOfferId { get; set; }
        public int NewPrice { get; set; }
        public string PromotionText { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        
    }

    public class Voter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Review Review { get; set; }
        public int ReviewId { get; set; }
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

            // Book - PriceOffer (one to one relationship)
            modelBuilder.Entity<Book>()
                .HasOne(s => s.PriceOffer)
                .WithOne(l => l.Book)
                .HasForeignKey<PriceOffer>();

            // Book - Review (one to many relationship)
            modelBuilder.Entity<Review>()
                .HasOne(b => b.Book)
                .WithMany(a => a.Reviews)
                .HasForeignKey(b => b.BookId);

            // Voter (PrimaryKey FirstName+LastName)
            modelBuilder.Entity<Voter>()
                .HasKey(v => new {v.FirstName, v.LastName});

            // Review- Voter (one to many relationship)
            modelBuilder.Entity<Voter>()
                .HasOne(v => v.Review)
                .WithMany(r => r.Voters)
                .HasForeignKey(v => v.ReviewId);

            // Book - Edition (one to many relationship)
            modelBuilder.Entity<Edition>()
                .HasOne(e => e.Book)
                .WithMany(b => b.Editions)
                .HasForeignKey(e => e.BookId);

            // Review - Edition (ont to many relationship)
            modelBuilder.Entity<Edition>()
                .HasOne(e => e.Review)
                .WithMany(r => r.Editions)
                .HasForeignKey(e => e.ReviewId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source = 192.168.211.134,1433;Database=BookSystem;User ID=SA;Password=Password1!;");
        
    }
}
