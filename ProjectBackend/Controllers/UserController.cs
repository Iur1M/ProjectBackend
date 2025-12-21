using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectBackend.Domain.Contracts;
using ProjectBackend.Service;

namespace ProjectBackend.Controllers
{
    [ApiController]
    [Route("api/users")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpGet("me")]
        public async Task<IActionResult> Me()
        {
            return Ok(await _userServices.GetCurrentUserAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(await _userServices.GetByIdAsync(id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _userServices.DeleteAsync(id);
            return NoContent();
        }
    }
}
