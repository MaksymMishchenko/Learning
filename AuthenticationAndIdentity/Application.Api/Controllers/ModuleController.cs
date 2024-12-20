using Microsoft.AspNetCore.Mvc;

namespace Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleController : ControllerBase
    {
        [HttpGet("GetModule")]
        public string Get()
        {
            return "Get a Module";
        }

        [HttpPost("AddModule")]
        public string Add()
        {
            return "Add a Module";
        }

        [HttpPut("UpdateModule")]
        public string Update()
        {
            return "Update a Module";
        }

        [HttpDelete("DeleteModule")]
        public string Delete()
        {
            return "Delete a Module";
        }
    }
}
