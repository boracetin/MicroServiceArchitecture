using AutoMapper;
using TenantService.Application.Features.Tenants.Dtos;
using TenantService.Domain.Entities;

namespace TenantService.Application.Features.Tenants.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles( )
        {
            //GetAll

            CreateMap<List<Tenant>, GetAllTenantOutputDto>();
            CreateMap<List<Tenant>, GetTenantOutputDto>();

            //GetById
            CreateMap<Tenant, GetTenantByIdInputDto>().ReverseMap();
            CreateMap<Tenant, GetTenantOutputDto>().ReverseMap();

            //Update
            CreateMap<Tenant, UpdateTenantInputDto>().ReverseMap();

            //Delete
            CreateMap<Tenant, DeleteTenantInputDto>().ReverseMap();

            //Create
            CreateMap<Tenant, CreateTenantInputDto>().ReverseMap();

        }
    }
}
