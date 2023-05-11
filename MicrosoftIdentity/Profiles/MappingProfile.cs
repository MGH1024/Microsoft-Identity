using AutoMapper;
using MicrosoftIdentity.Entities;
using MicrosoftIdentity.Models;

namespace MicrosoftIdentity.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        //Identity
        CreateMap<CreateUser, User>();
    }
}