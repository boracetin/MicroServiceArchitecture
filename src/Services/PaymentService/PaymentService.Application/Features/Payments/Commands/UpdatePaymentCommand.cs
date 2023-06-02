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
    public class UpdatePaymentCommand:IRequest<Unit>
    {
        public UpdatePaymentInputDto Input { get; set; }
        public class UpdatePaymentCommandHandler : IRequestHandler<UpdatePaymentCommand, Unit>
        {
            private readonly IPaymentRepository _paymentRepository;

            private readonly IMapper _mapper;
            public UpdatePaymentCommandHandler(IPaymentRepository paymentRepository, IMapper mapper)
            {
                _paymentRepository = paymentRepository;
                _mapper = mapper;
            }
            public async Task<Unit> Handle(UpdatePaymentCommand request, CancellationToken cancellationToken)
            {
                Payment payment = await _paymentRepository.GetElemanById(request.Input.Id);
                payment.SuccessUrl = request.Input.SuccessUrl;

                await _paymentRepository.Update(payment);

                return Unit.Value;
            }
        }
    }
}
