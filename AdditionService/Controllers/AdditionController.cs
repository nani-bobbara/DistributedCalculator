using Microsoft.AspNetCore.Mvc;

namespace AdditionService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdditionController : ControllerBase
    {       

        private readonly ILogger<AdditionController> _logger;

        public AdditionController(ILogger<AdditionController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "add")]
        public int Get(int first, int second)
        {
            _logger.LogInformation($"The sum of {first} + {second} = {first + second}");
            return first + second;
        }
    }
}