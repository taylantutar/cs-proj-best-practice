using AutoMapper;
using TT.Api.Data.Model;
using TT.Api.Model;

namespace TT.Api.Mapping
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<Post, PostDto>()
                                      .ForMember(x => x.Title , y=> y.MapFrom(z => z.Title))
                                      .ReverseMap();
        }
    }
}
