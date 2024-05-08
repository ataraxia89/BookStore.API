using System.Net;
using BookStore.API.Data;
using BookStore.API.Data.Repositories.Interfaces;
using BookStore.Models.Books;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController(IBooksRepository booksRepository) : ControllerBase
{
    [HttpGet("seedData")]
    public async Task<ActionResult> SeedDataAsync()
    {
        foreach (var book in SeedData.SampleBookList)
        {
            await booksRepository.CreateAsync(book);
        }

        return Ok(await booksRepository.GetAllAsync());
    }

    [HttpGet]
    public async Task<ActionResult<List<BookDTO>>> GetBooksAsync()
    {
        return Ok(await booksRepository.GetAllAsync());
    }

    [HttpGet("{bookId}")]
    public async Task<ActionResult<BookDTO>> GetBookAsync(long bookId)
    {
        if (!await booksRepository.ExistsAsync(bookId))
        {
            return NotFound();
        }

        return Ok(await booksRepository.GetAsync(bookId));
    }

    [HttpPost]
    public async Task<ActionResult<BookDTO>> AddBookAsync([FromBody] CreateBookDTO createDTO)
    {
        return StatusCode((int)HttpStatusCode.Created, await booksRepository.CreateAsync(createDTO));
    }

    [HttpPut("{bookId}")]
    public async Task<ActionResult<BookDTO>> UpdateBookAsync(long bookId, [FromBody] UpdateBookDTO updateDTO)
    {
        return Ok(await booksRepository.UpdateAsync(bookId, updateDTO));
    }

    [HttpDelete("{bookId}")]
    public async Task<ActionResult> DeleteBookAsync(long bookId)
    {
        await booksRepository.DeleteAsync(bookId);

        return NoContent();
    }
}