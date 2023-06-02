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
    public class GetPaymentByIdQuery:IRequest<GetPaymentOutputDto>
    {
        public GetPaymentByIdInputDto Input { get; set; }

        public class GetPaymentByIdQueryHandler : IRequestHandler<GetPaymentByIdQuery, GetPaymentOutputDto>
        {
            private readonly IPaymentRepository _paymentRepository;
            private readonly IMapper _mapper;

            public GetPaymentByIdQueryHandler(IPaymentRepository paymentRepository, IMapper mapper)
            {
                _paymentRepository = paymentRepository;
                _mapper = mapper;
            }

            public async Task<GetPaymentOutputDto> Handle(GetPaymentByIdQuery request, CancellationToken cancellationToken)
            {
                Payment result = await _paymentRepository.GetElemanById(request.Input.Id);
                GetPaymentOutputDto mappedPayment = _mapper.Map<GetPaymentOutputDto>(result);

                return mappedPayment;
            }
        }
    }
}
