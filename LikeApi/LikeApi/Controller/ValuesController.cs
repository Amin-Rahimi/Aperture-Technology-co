using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LikeApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", "value3" };
        }

        [HttpGet("{id}")]

        public string Get(int id)
        {
            return "the value is " + id;
        }
    }
}
