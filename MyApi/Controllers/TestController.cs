using Microsoft.AspNetCore.Mvc;
using SimpleDll;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {

        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetGreeting")]
        public string GetGreeting(string name)
        {
            var myClass = new MyClass();
            return myClass.GreetUser(name);
        }
    }
}
