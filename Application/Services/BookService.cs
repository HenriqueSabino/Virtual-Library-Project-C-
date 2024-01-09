using Core.Entities;
using Core.Interfaces;
using Application.DTOs;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BookService(IBookRepository bookRepository, IUnitOfWork unitOfWork)
        {
            _bookRepository = bookRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<BookDTO>> GetAllBooksAsync()
        {
            var books = await _bookRepository.GetAllAsync();
            var bookDTOs = new List<BookDTO>();

            foreach (var book in books)
            {
                bookDTOs.Add(new BookDTO
                {
                    Id = book.Id,
                    Title = book.Title,
                    Author = book.Author,
                    ISBN = book.ISBN,
                    Status = book.Status
                });
            }

            return bookDTOs;
        }

        public async Task<BookDTO> GetBookByIdAsync(int id)
        {
            var book = await _bookRepository.GetByIdAsync(id);

            if (book == null)
                return null;

            return new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                ISBN = book.ISBN,
                Status = book.Status
            };
        }

        public async Task<BookDTO> AddBookAsync(BookDTO bookDTO)
        {
            var book = new Book
            {
                Title = bookDTO.Title,
                Author = bookDTO.Author,
                ISBN = bookDTO.ISBN,
                Status = bookDTO.Status
            };

            await _bookRepository.AddAsync(book);
            await _unitOfWork.CompleteAsync();

            bookDTO.Id = book.Id;
            return bookDTO;
        }

        public async Task UpdateBookAsync(BookDTO bookDTO)
        {
            var book = await _bookRepository.GetByIdAsync(bookDTO.Id);

            if (book == null)
                throw new InvalidOperationException("Book not found.");

            book.Title = bookDTO.Title;
            book.Author = bookDTO.Author;
            book.ISBN = bookDTO.ISBN;
            book.Status = bookDTO.Status;

            _bookRepository.Update(book);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteBookAsync(int id)
        {
            var book = await _bookRepository.GetByIdAsync(id);

            if (book == null)
                throw new InvalidOperationException("Book not found.");

            _bookRepository.Delete(book);
            await _unitOfWork.CompleteAsync();
        }
    }
}