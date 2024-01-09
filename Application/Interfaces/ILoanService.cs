using System.Collections.Generic;
using System.Threading.Tasks;
using VirtualLibrary.Application.DTOs;

namespace VirtualLibrary.Application.Interfaces
{
    public interface ILoanService
    {
        Task<IEnumerable<LoanDTO>> GetAllLoansAsync();
        Task<LoanDTO> GetLoanByIdAsync(int id);
        Task<LoanDTO> CreateLoanAsync(LoanDTO loanDto);
        Task<LoanDTO> UpdateLoanAsync(int id, LoanDTO loanDto);
        Task<bool> DeleteLoanAsync(int id);
    }
}