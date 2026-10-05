using Reyes_MIdterm.DTO.CommunityLibraryAPI.DTOs;

namespace Reyes_Midterm.Services
{
    public interface ILoanService
    {
        Task<string> BorrowBookAsync(LoanDto dto);
        Task<string> ReturnBookAsync(int loanId);
    }
}
