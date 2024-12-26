using Application.Services.Models.TypeSafe;
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
        //[Authorize(Roles = "Admin")]
        //[Authorize(Roles = "Admin, Contributor")]
        [Authorize(Roles = $"{TS.Roles.Admin}, {TS.Roles.Contributor}, {TS.Roles.User}")]
        public string Get()
        {
            return "Get a Class Room";
        }
        
        [HttpPost("AddClassRoom")]
        //[Authorize(Roles = "Admin")]
        [Authorize(Roles = $"{TS.Roles.Admin}, {TS.Roles.Contributor}")]
        public string Add()
        {
            return "Add a Class Room";
        }

        [HttpPut("UpdateClassRoom")]
        [Authorize(Roles = $"{TS.Roles.Admin}")]
        public string Update()
        {
            return "Update a Class Room";
        }

        [HttpDelete("DeleteClassRoom")]
        [Authorize(Roles = $"{TS.Roles.Admin}")]
        public string Delete()
        {
            return "Delete a Class Room";
        }
    }
}
