using CommunityLibraryAPI.Data;
using Reyes_MIdterm.DTO.CommunityLibraryAPI.DTOs;
using Reyes_MIdterm.Models.CommunityLibraryAPI.Models;

namespace Reyes_Midterm.Services
{
    public class LoanService : ILoanService
    {
        private readonly LibraryDbContext _context;

        public LoanService(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task<string> BorrowBookAsync(LoanDto dto)
        {
            var book = await _context.Books.FindAsync(dto.BookId);

            if (book == null)
                return "Book not found";

            var member = await _context.Members.FindAsync(dto.MemberId);

            if (member == null)
                return "Member not found";

            if (!member.IsActive)
                return "Inactive member";

            if (book.AvailableCopies <= 0)
                return "No copies available";

            var activeLoans =
                await _context.Loans.CountAsync(x =>
                    x.MemberId == dto.MemberId &&
                    x.Status == "Borrowed");

            if (activeLoans >= 3)
                return "Loan limit reached";

            book.AvailableCopies--;

            Loan loan = new()
            {
                BookId = dto.BookId,
                MemberId = dto.MemberId,
                BorrowedDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(7),
                Status = "Borrowed"
            };

            _context.Loans.Add(loan);

            await _context.SaveChangesAsync();

            return "Book Borrowed";
        }

        public async Task<string> ReturnBookAsync(int loanId)
        {
            var loan = await _context.Loans.FindAsync(loanId);

            if (loan == null)
                return "Loan not found";

            if (loan.ReturnedDate != null)
                return "Already returned";

            loan.ReturnedDate = DateTime.Now;
            loan.Status = "Returned";

            var book = await _context.Books.FindAsync(loan.BookId);

            if (book != null)
                book.AvailableCopies++;

            await _context.SaveChangesAsync();

            return "Book Returned";
        }
    }
}
