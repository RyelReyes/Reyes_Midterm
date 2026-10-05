using Reyes_MIdterm.Models.CommunityLibraryAPI.Models;

namespace Reyes_Midterm.Services
{
    public interface IMemberService
    {
        Task<List<Member>> GetAllAsync();
        Task<Member?> GetByIdAsync(int id);
    }
}
