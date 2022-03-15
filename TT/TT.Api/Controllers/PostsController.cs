using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TT.Api.Data.Model;
using TT.Api.Service;

namespace TT.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IPostService postService;
        private readonly ILogger<PostsController> _logger;

        public PostsController(IConfiguration config, IPostService postService, ILogger<PostsController> logger)
        {
            _config = config;
            this.postService = postService;
            _logger = logger;
        }

        public string Get()
        {
            _logger.LogDebug("Debug log");
            return _config["Str"].ToString();
        }

        [ResponseCache(Duration = 60)]
        [HttpGet("{id}")]
        public PostDto GetById(int id)
        {
            return postService.GetById(id);
        }

        [HttpPost]
        public IActionResult Create(PostDto postDto)
        {
            return Created("", new object());
        }
    }
}
