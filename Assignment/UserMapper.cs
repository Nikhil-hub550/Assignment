using Assignment.DataAccess.Models;
using Assignment.DTOs;
using AutoMapper;

namespace Assignment
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<CreateUserDto, User>()
                .ForMember(dest => dest.UserNo, opt => opt.Ignore()) // Ignore Id during mapping
                .ForMember(dest => dest.Hobbies, opt => opt.MapFrom(src => src.Hobbies));

            CreateMap<HobbyDto, Hobby>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserNo))
                .ReverseMap();

            CreateMap<User, GetAllUserDto>()
                .ForMember(dest => dest.Hobbies, opt => opt.MapFrom(src => src.Hobbies));

            CreateMap<UpdateUserDto, User>()                
                .ForMember(dest => dest.Hobbies, opt => opt.MapFrom(src => src.Hobbies));
        }
    }
}
