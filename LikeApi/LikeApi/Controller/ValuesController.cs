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
            return new string[] { "Muhammad", "Amin", "Reza" };
        }

        [HttpGet("{id}")]

        public string Get(int id)
        {
            return "the name is " + id;
        }
    }
}
