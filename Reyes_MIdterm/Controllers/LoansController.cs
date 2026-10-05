using Microsoft.AspNetCore.Mvc;
using Reyes_Midterm.Services;
using Reyes_MIdterm.DTO.CommunityLibraryAPI.DTOs;

namespace Reyes_Midterm.Controllers
{
    [ApiController]
    [Route("api/loans")]
    public class LoansController : ControllerBase
    {
        private readonly ILoanService _loanService;

        public LoansController(ILoanService loanService)
        {
            _loanService = loanService;
        }

        [HttpPost]
        public async Task<IActionResult> BorrowBook(LoanDto dto)
        {
            var result = await _loanService.BorrowBookAsync(dto);

            return Ok(result);
        }

        [HttpPost("{id}/return")]
        public async Task<IActionResult> ReturnBook(int id)
        {
            var result = await _loanService.ReturnBookAsync(id);

            return Ok(result);
        }
    }
}
