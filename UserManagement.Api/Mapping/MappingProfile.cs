// -----------------------------------------------------
//     Class name
//     Author: Alberto José Pedrera Ros
//------------------------------------------------------

using AutoMapper;
using System.Collections.Generic;
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

            CreateMap<PatchDto, Patch>();
        }
    }
}