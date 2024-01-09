using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Application.DTOs;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibrariansController : ControllerBase
    {
        private readonly ILibrarianService _librarianService;

        public LibrariansController(ILibrarianService librarianService)
        {
            _librarianService = librarianService;
        }

        // Get a list of librarians
        [HttpGet]
        public async Task<IActionResult> GetAllLibrarians()
        {
            var librarians = await _librarianService.GetAllLibrariansAsync();
            return Ok(librarians);
        }

        // Get a single librarian by id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLibrarian(int id)
        {
            var librarian = await _librarianService.GetLibrarianByIdAsync(id);
            if (librarian == null) return NotFound();
            return Ok(librarian);
        }

        // Create a new librarian
        [HttpPost]
        public async Task<IActionResult> CreateLibrarian([FromBody] LibrarianDTO librarianDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            
            var createdLibrarian = await _librarianService.CreateLibrarianAsync(librarianDto);
            return CreatedAtAction(nameof(GetLibrarian), new { id = createdLibrarian.Id }, createdLibrarian);
        }

        // Update an existing librarian
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLibrarian(int id, [FromBody] LibrarianDTO librarianDto)
        {
            if (id != librarianDto.Id) return BadRequest("Mismatched librarian ID");
            
            var updatedLibrarian = await _librarianService.UpdateLibrarianAsync(librarianDto);
            return Ok(updatedLibrarian);
        }

        // Delete a librarian
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLibrarian(int id)
        {
            var result = await _librarianService.DeleteLibrarianAsync(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}