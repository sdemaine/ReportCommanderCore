using AutoMapper;
using ReportCommander.API.Endpoints;
using ReportCommander.Application.Dtos;
using ReportCommander.Domain;
using ReportCommander.Core.Entities;

namespace ReportCommander.API.MappingProfiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<UserProfile, UserProfileDto>().ReverseMap();

        CreateMap<Config, ConfigCreateRequest>().ReverseMap();
        CreateMap<Config, ConfigCreateResult>().ReverseMap();

        CreateMap<Config, ConfigListResult>().ReverseMap();
    }
}
