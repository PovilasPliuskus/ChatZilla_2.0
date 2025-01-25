using ChatZilla.User.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChatZilla.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        
        public UserController(IUserService testService)
        {
            _userService = testService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _userService.GetUserAsync(Guid.NewGuid());
            return Ok();
        }
    }
}
