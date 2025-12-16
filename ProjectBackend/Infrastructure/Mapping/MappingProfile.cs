using AutoMapper;
using ProjectBackend.Domain.Contracts;
using ProjectBackend.Domain.Entities;

namespace ProjectBackend.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserResponse>();
            CreateMap<ApplicationUser, CurrentUserResponse>();
            CreateMap<UserRegisterRequest, ApplicationUser>();
            CreateMap<Movie, MovieDto>();
        }
    }
}