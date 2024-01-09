using System;
using Core.Entities;

namespace Core.UseCases
{
    public interface IManageBookUseCase
    {
        void UpdateBookInfo(Book updatedBook);
        void ChangeBookStatus(Guid bookId, BookStatus newStatus);
        void ReserveBook(Guid bookId, Guid studentId);
    }
}