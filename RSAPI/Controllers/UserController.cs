using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RS_API.Communication.Requests;
using RS_API.Communication.Responses;

namespace RS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        public IActionResult GetById([FromRoute] int id)
        {
            var response = new User { Id = id, Name = "Alessandro" };
            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(typeof(RegisterUserResponse), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] RegisterUserRequest request)
        {
            var response = new RegisterUserResponse
            {
                Id = 1,
                Name = request.Name,
            };
            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update([FromRoute] int Id, [FromBody] UpdateUserRequest request)
        {
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete()
        {
            return NoContent();
        }
    }
}
