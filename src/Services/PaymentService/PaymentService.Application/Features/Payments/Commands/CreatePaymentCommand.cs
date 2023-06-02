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

namespace PaymentService.Application.Features.Payments.Commands
{
    public class CreatePaymentCommand:IRequest<Unit>
    {
        public CreatePaymentInputDto Input { get; set; }
        public class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommand, Unit>
        {
            private readonly IPaymentRepository _paymentRepository;

            private readonly IMapper _mapper;
            public CreatePaymentCommandHandler(IPaymentRepository paymentRepository, IMapper mapper)
            {
                _paymentRepository = paymentRepository;
                _mapper = mapper;
            }
            public async Task<Unit> Handle(CreatePaymentCommand request, CancellationToken cancellationToken)
            {
                Payment mappedPayment = _mapper.Map<Payment>(request.Input);
                mappedPayment.CreatedTime = DateTime.UtcNow;
                mappedPayment.PaymentStatus = PaymentStatusEnum.Completed;

                await _paymentRepository.Create(mappedPayment);

                return Unit.Value;
            }
        }
    }
}
