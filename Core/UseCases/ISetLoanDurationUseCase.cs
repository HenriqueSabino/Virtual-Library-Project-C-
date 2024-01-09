using System.Threading.Tasks;

namespace VirtualLibrary.Core.UseCases
{
    public interface ISetLoanDurationUseCase
    {
        Task SetStandardLoanDurationAsync(int durationDays);
    }
}