using BookStore.API.Data.EntityFramework;
using BookStore.API.Data.Repositories.Interfaces;
using BookStore.Models.Books;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Data.Repositories;

public class BooksRepository(BookStoreDbContext context) : IBooksRepository
{
    public async Task<bool> ExistsAsync(long id)
    {
        return await context.Books.AnyAsync(b => b.Id == id);
    }

    public async Task<List<BookDTO>> GetAllAsync()
    {
        return await context.Books
            .Select(b => new BookDTO
            {
                Id = b.Id,
                Title = b.Title,
                Author = b.Author,
                PublishDate = b.PublishDate,
                Pages = b.Pages,
                Genre = b.Genre,
                Synopsis = b.Synopsis,
                Rating = b.Rating,
                ISBN = b.ISBN
            })
            .ToListAsync();
    }

    public async Task<BookDTO> GetAsync(long id)
    {
        return await context.Books
            .Where(b => b.Id == id)
            .Select(b => new BookDTO
            {
                Id = b.Id,
                Title = b.Title,
                Author = b.Author,
                PublishDate = b.PublishDate,
                Pages = b.Pages,
                Genre = b.Genre,
                Synopsis = b.Synopsis,
                Rating = b.Rating,
                ISBN = b.ISBN
            })
            .FirstAsync();
    }

    public async Task<BookDTO> CreateAsync(CreateBookDTO createDTO)
    {
        var book = (await context.Books.AddAsync(new Book
        {
            Title = createDTO.Title,
            Author = createDTO.Author,
            PublishDate = createDTO.PublishDate,
            Pages = createDTO.Pages,
            Genre = createDTO.Genre,
            Synopsis = createDTO.Synopsis,
            Rating = createDTO.Rating,
            ISBN = createDTO.ISBN
        })).Entity;

        await context.SaveChangesAsync();

        return new BookDTO
        {
            Id = book.Id,
            Title = book.Title,
            Author = book.Author,
            PublishDate = book.PublishDate,
            Pages = book.Pages,
            Genre = book.Genre,
            Synopsis = book.Synopsis,
            Rating = book.Rating,
            ISBN = book.ISBN
        };
    }

    public async Task<BookDTO> UpdateAsync(long id, UpdateBookDTO updateDTO)
    {
        var book = await context.Books.FirstAsync(b => b.Id == id);

        book.Title = updateDTO.Title;
        book.Author = updateDTO.Author;
        book.Pages = updateDTO.Pages;
        book.Genre = updateDTO.Genre;
        book.Synopsis = updateDTO.Synopsis;
        book.Rating = updateDTO.Rating;
        book.ISBN = updateDTO.ISBN;

        await context.SaveChangesAsync();

        return new BookDTO
        {
            Id = book.Id,
            Title = book.Title,
            Author = book.Author,
            PublishDate = book.PublishDate,
            Pages = book.Pages,
            Genre = book.Genre,
            Synopsis = book.Synopsis
        };
    }

    public async Task DeleteAsync(long id)
    {
        context.Books.Remove(await context.Books.FirstAsync(b => b.Id == id));

        await context.SaveChangesAsync();
    }
}