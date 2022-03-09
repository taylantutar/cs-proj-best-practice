using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TT.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IConfiguration _config;

        public PostsController(IConfiguration config)
        {
            _config = config;
        }

        public string Get()
        {
            return _config["Str"].ToString();
        }
    }
}
