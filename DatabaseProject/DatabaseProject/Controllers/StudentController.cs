using DatabaseProject.Models;
using DatabaseProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllStudentsAsync()
        {
            return Ok(await _studentService.GetStudentsAsync());
        }

        [HttpGet("GetAsync/{id}")]
        public async Task<IActionResult> GetStudentAsync(int id)
        {
            var value = await _studentService.GetStudentAsync(id);
            if (value is null)
            {
                return NotFound("The item not found");
            }
            return Ok(value);
        }

        [HttpPost("AddAsync")]
        public async Task<IActionResult> GetAllStudentsAsync(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Model is not valid");
            }

            if (await _studentService.AddStudentAsync(student))
            {
                return Ok("Done");
            }
            return BadRequest("Something went wrong please try again");
        }

        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> EditStudentAsync(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Model is Not Valid.");
            }

            if (await _studentService.EditStudentAsync(student))
            {
                return Ok("Done");
            }
            return BadRequest("Something went wrong please try again.");
        }

        [HttpDelete("DeleteAsync")]
        public async Task<IActionResult> DeleteAsync(int Id)
        {
            if (await _studentService.DeleteStudentAsync(Id))
            {
                return Ok("Done");
            }
            return BadRequest("Something went wrong please try again.");
        }
    }
}
