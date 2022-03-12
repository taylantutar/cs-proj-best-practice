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

        public PostsController(IConfiguration config , IPostService postService)
        {
            _config = config;
            this.postService = postService;
        }

        public string Get()
        {
            return _config["Str"].ToString();
        }

        [HttpGet("{id}")]
        public  PostDto GetById(int id)
        {
            return postService.GetById(id);
        }
    }
}
