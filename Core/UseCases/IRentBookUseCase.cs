using Core.Entities;

namespace Core.UseCases
{
    public interface IRentBookUseCase
    {
        void RentBook(Student student, Book book);
    }
}