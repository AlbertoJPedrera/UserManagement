using AutoMapper;
using UserManagement.Api.Resources;
using UserManagement.Core.Models;

namespace UserManagement.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<User, UserResource>();

            // Resource to Domain
            CreateMap<UserResource, User>();
        }
    }
}
