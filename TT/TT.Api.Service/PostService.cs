using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Api.Data.Model;
using TT.Api.Model;

namespace TT.Api.Service
{
    public class PostService : IPostService
    {
        public IMapper _mapper { get; }

        public PostService(IMapper mapper)
        {
            _mapper = mapper;
        }


        public PostDto GetById(int id)
        {
            //fake data. get from db
            var post = new Post()
            {
                Id = 1,
                Title = "Title",
                Content = "Body"
            };

            PostDto postDto = _mapper.Map<PostDto>(post);

            return postDto;
        }
    }
}
