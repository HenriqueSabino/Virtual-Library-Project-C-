using Microsoft.AspNetCore.Mvc;
using VirtualLibrary.Application.Interfaces;
using VirtualLibrary.Application.DTOs;

namespace VirtualLibrary.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student != null)
            {
                return Ok(student);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody] StudentDTO studentDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var student = _studentService.CreateStudent(studentDto);
            return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] StudentDTO studentDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedStudent = _studentService.UpdateStudent(id, studentDto);
            if (updatedStudent != null)
            {
                return Ok(updatedStudent);
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var success = _studentService.DeleteStudent(id);
            if (success)
            {
                return NoContent();
            }

            return NotFound();
        }
    }
}