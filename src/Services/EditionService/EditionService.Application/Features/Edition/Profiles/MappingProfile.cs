using AutoMapper;
using EditionService.Application.Features.Edition.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EditionService.Domain;

namespace EditionService.Application.Features.Edition.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {

            //GetAll
            CreateMap<GetAllEditionInputDto, EditionInfo>().ReverseMap();
            CreateMap<GetEditionOutputDto, List<EditionInfo>>().ReverseMap();


            //Create
            CreateMap<CreateEditionInputDto, EditionInfo>().ReverseMap();
            //Delete
            CreateMap<DeleteEditionInputDto, EditionInfo>().ReverseMap();
      

            //Update
            CreateMap<UpdateEditionInputDto, EditionInfo>().ReverseMap();
        



            //GetById
            CreateMap<GetEditionByIdInputDto, EditionInfo>().ReverseMap();
            CreateMap<GetEditionOutputDto, EditionInfo>().ReverseMap();

        }
    }
}
