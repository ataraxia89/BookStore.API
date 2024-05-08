using BookStore.Models.Books;

namespace BookStore.API.Data.Repositories.Interfaces;

public interface IBooksRepository
{
    Task<bool> ExistsAsync(long id);

    Task<List<BookDTO>> GetAllAsync();

    Task<BookDTO> GetAsync(long id);

    Task<BookDTO> CreateAsync(CreateBookDTO createDTO);

    Task<BookDTO> UpdateAsync(long id, UpdateBookDTO updateDTO);

    Task DeleteAsync(long id);
}