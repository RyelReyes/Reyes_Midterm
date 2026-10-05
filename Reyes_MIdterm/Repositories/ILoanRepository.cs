using Reyes_MIdterm.Models.CommunityLibraryAPI.Models;

namespace Reyes_MIdterm.Repositories
{
    public interface ILoanRepository
    {
        Task<List<Loan>> GetAllAsync();
        Task<Loan?> GetByIdAsync(int id);
        Task AddAsync(Loan loan);
    }
}
