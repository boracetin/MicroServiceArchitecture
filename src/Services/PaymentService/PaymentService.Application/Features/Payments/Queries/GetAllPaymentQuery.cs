using AutoMapper;
using MediatR;
using PaymentService.Application.Features.Payments.Dtos;
using PaymentService.Application.Services;
using PaymentService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Application.Features.Payments.Queries
{
    public class GetAllPaymentQuery : IRequest<List<GetPaymentOutputDto>>
    {

        public class GetAllPaymentQueryHandler : IRequestHandler<GetAllPaymentQuery, List<GetPaymentOutputDto>>
        {
            private readonly IPaymentRepository _paymentRepository;
            private readonly IMapper _mapper;

            public GetAllPaymentQueryHandler(IPaymentRepository paymentRepository, IMapper mapper)
            {
                _paymentRepository = paymentRepository;
                _mapper = mapper;
            }

            public async Task<List<GetPaymentOutputDto>> Handle(GetAllPaymentQuery request, CancellationToken cancellationToken)
            {
                List<Payment> payments =await _paymentRepository.GetAll();
                List<GetPaymentOutputDto> mappedPayments =_mapper.Map<List<Payment>,List<GetPaymentOutputDto>>(payments);

                return mappedPayments;
            }
        }
    }
}