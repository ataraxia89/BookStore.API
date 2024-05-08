using BookStore.API.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Data;

public sealed class BookStoreDbContext : DbContext
{
    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Book> Books { get; set; }
}