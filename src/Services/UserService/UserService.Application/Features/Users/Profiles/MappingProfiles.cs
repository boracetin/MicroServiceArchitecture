using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Application.Features.Users.Dtos;
using UserService.Domain;

namespace UserService.Application.Features.Users.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //GetAll

            CreateMap<List<User>, GetAllUserOutputDto>();
            CreateMap<List<User>, GetUserOutputDto>();

            //GetById
            CreateMap<User, GetUserByIdInputDto>().ReverseMap();
            CreateMap<User, GetUserOutputDto>().ReverseMap();

            //Update
            CreateMap<User, UpdateUserInputDto>().ReverseMap();

            //Delete
            CreateMap<User, DeleteUserInputDto>().ReverseMap();

            //Create
            CreateMap<User, CreateUserInputDto>().ReverseMap();

        }
    }
}
