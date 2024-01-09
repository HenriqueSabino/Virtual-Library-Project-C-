using Core.Entities;
using System.Threading.Tasks;

namespace Core.UseCases
{
    public interface IRegisterStudentUseCase
    {
        Task<Student> RegisterStudentAsync(Student student);
    }
}