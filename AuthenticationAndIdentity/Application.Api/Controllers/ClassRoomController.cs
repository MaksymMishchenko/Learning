using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClassRoomController : ControllerBase
    {
        [HttpGet("GetClassRoom")]
        public string Get()
        {
            return "Get a Class Room";
        }

        [HttpPost("AddClassRoom")]
        public string Add()
        {
            return "Add a Class Room";
        }

        [HttpPut("UpdateClassRoom")]
        public string Update()
        {
            return "Update a Class Room";
        }

        [HttpDelete("DeleteClassRoom")]
        public string Delete()
        {
            return "Delete a Class Room";
        }
    }
}
