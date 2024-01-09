using Core.Interfaces;
using Core.Entities;
using Application.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Application.Services
{
    public class LoanService : ILoanService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LoanService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BookDTO> RentBookAsync(int bookId, int studentId)
        {
            // Implementation for renting a book
            var book = await _unitOfWork.Books.GetAsync(bookId);
            if (book == null || book.Status != "Available")
            {
                throw new KeyNotFoundException("Book is not available for rent.");
            }

            var student = await _unitOfWork.Students.GetAsync(studentId);
            if (student == null)
            {
                throw new KeyNotFoundException("Student not found.");
            }

            book.Status = "Rented";
            student.RentalHistory.Add(book);
            await _unitOfWork.CompleteAsync();

            return _mapper.Map<BookDTO>(book);
        }

        public async Task<BookDTO> ReturnBookAsync(int bookId, int librarianId)
        {
            // Implementation for returning a book
            var book = await _unitOfWork.Books.GetAsync(bookId);
            if (book == null || book.Status != "Rented")
            {
                throw new KeyNotFoundException("Book is not rented and cannot be returned.");
            }

            var librarian = await _unitOfWork.Librarians.GetAsync(librarianId);
            if (librarian == null)
            {
                throw new KeyNotFoundException("Librarian not found.");
            }

            book.Status = "Available";
            await _unitOfWork.CompleteAsync();

            return _mapper.Map<BookDTO>(book);
        }

        public async Task<IEnumerable<LoanDTO>> GetLoanHistoryAsync(int studentId)
        {
            // Implementation for retrieving the loan history of a student
            var student = await _unitOfWork.Students.GetAsync(studentId);
            if (student == null)
            {
                throw new KeyNotFoundException("Student not found.");
            }

            var loanHistory = student.RentalHistory;
            return _mapper.Map<IEnumerable<LoanDTO>>(loanHistory);
        }

        // Add additional methods as needed for loan management
    }
}