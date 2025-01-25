using ChatZilla.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChatZilla.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly TestService _testService;
        
        public TestController(TestService testService)
        {
            _testService = testService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _testService.GetAllAsync();
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Post(MyModel model)
        {
            await _testService.AddAsync(model);
            return Ok();
        }
    }
}
