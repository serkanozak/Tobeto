using AutoMapper;
using Business.Dtos.Auth.Requests;
using Business.Dtos.Auth.Responses;
using Business.Dtos.User.Requests;
using Business.Dtos.User.Responses;
using Core.DataAccess.Paging;
using Core.Entities.Concretes;

namespace Business.Profiles;

public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<User, CreateUserRequest>().ReverseMap();
        CreateMap<User, DeleteUserRequest>().ReverseMap();
        CreateMap<User, UpdateUserRequest>().ReverseMap();
        CreateMap<User, LoginAuthRequest>().ReverseMap();
        CreateMap<User, LoginAuthResponse>().ReverseMap();
        CreateMap<User, RegisterAuthRequest>().ReverseMap();
        CreateMap<User, RegisterAuthResponse>().ReverseMap();
        CreateMap<GetUserResponse, RegisterAuthResponse>().ReverseMap();
        CreateMap<GetUserResponse, LoginAuthResponse>().ReverseMap();
        CreateMap<User, GetUserResponse>().ReverseMap();
        CreateMap<Paginate<User>, Paginate<GetListUserResponse>>().ReverseMap();
    }
}
