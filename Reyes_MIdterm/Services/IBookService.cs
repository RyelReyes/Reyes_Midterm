using Reyes_MIdterm.DTO.CommunityLibraryAPI.DTOs;
using Reyes_MIdterm.Models.CommunityLibraryAPI.Models;

namespace Reyes_MIdterm.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetAllAsync();
        Task<Book?> GetByIdAsync(int id);
        Task<Book> CreateAsync(BookDto dto);
    }
}
