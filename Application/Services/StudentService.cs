using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VirtualLibrary.Core.Entities;
using VirtualLibrary.Core.Interfaces;

namespace VirtualLibrary.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IUnitOfWork _unitOfWork;

        public StudentService(IStudentRepository studentRepository, IUnitOfWork unitOfWork)
        {
            _studentRepository = studentRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Student> RegisterStudentAsync(Student student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));

            await _studentRepository.AddAsync(student);
            await _unitOfWork.CommitAsync();
            return student;
        }

        public async Task<Student> UpdateStudentAsync(Student student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));

            _studentRepository.Update(student);
            await _unitOfWork.CommitAsync();
            return student;
        }

        public async Task<Student> GetStudentByIdAsync(Guid studentId)
        {
            return await _studentRepository.GetByIdAsync(studentId);
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _studentRepository.GetAllAsync();
        }

        public async Task DeleteStudentAsync(Guid studentId)
        {
            var student = await _studentRepository.GetByIdAsync(studentId);

            if (student != null)
            {
                _studentRepository.Remove(student);
                await _unitOfWork.CommitAsync();
            }
        }
    }
}