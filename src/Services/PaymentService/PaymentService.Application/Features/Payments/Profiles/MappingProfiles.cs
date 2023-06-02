using AutoMapper;
using PaymentService.Application.Features.Payments.Dtos;
using PaymentService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Application.Features.Payments.Profiles
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            //GetAll
            CreateMap<List<Payment>, GetAllPaymentOutputDto>();
            CreateMap<List<Payment>, GetPaymentOutputDto>().ReverseMap();

            //GetById
            CreateMap<Payment, GetPaymentByIdInputDto>().ReverseMap();
            CreateMap<Payment, GetPaymentOutputDto>().ReverseMap();
            //Update
            CreateMap<Payment, UpdatePaymentInputDto>().ReverseMap();

            //Delete
            CreateMap<Payment, DeletePaymentInputDto>().ReverseMap();

            //Create
            CreateMap<Payment, CreatePaymentInputDto>().ReverseMap();

        }

    }
}
