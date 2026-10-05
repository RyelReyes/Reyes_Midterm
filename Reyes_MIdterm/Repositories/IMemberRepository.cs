using Reyes_MIdterm.Models.CommunityLibraryAPI.Models;

namespace Reyes_MIdterm.Repositories
{
    public interface IMemberRepository
    {
        Task<List<Member>> GetAllAsync();
        Task<Member?> GetByIdAsync(int id);
        Task AddAsync(Member member);
    }
}
