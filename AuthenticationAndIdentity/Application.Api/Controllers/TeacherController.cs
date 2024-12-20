using Microsoft.AspNetCore.Mvc;

namespace Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        [HttpGet("GetTeacher")]
        public string Get()
        {
            return "Get a Teacher";
        }

        [HttpPost("AddTeacher")]
        public string Add()
        {
            return "Add a Teacher";
        }

        [HttpPut("UpdateTeacher")]
        public string Update()
        {
            return "Update a Teacher";
        }

        [HttpDelete("DeleteTeacher")]
        public string Delete()
        {
            return "Delete a Teacher";
        }
    }
}
