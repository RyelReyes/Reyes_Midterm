using Reyes_MIdterm.Models.CommunityLibraryAPI.Models;

namespace Reyes_MIdterm.Repositories
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllAsync();
        Task<Book?> GetByIdAsync(int id);
        Task AddAsync(Book book);
        Task UpdateAsync(Book book);
        Task DeleteAsync(Book book);
    }
``
}
