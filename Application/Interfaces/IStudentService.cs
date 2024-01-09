using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IStudentService
    {
        Task<StudentDTO> RegisterStudentAsync(StudentDTO studentDto);
        Task<StudentDTO> UpdateStudentAsync(StudentDTO studentDto);
        Task<StudentDTO> GetStudentByIdAsync(int id);
        Task<IEnumerable<StudentDTO>> GetAllStudentsAsync();
        Task DeleteStudentAsync(int id);
    }
}