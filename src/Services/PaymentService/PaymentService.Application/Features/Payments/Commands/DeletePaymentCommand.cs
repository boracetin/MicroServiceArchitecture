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
    public class DeletePaymentCommand:IRequest<Unit>
    {
        public DeletePaymentInputDto Input { get; set; }
        public class DeletePaymentCommandHandler : IRequestHandler<DeletePaymentCommand, Unit>
        {
            private readonly IPaymentRepository _paymentRepository;

            private readonly IMapper _mapper;
            public DeletePaymentCommandHandler(IPaymentRepository paymentRepository, IMapper mapper)
            {
                _paymentRepository = paymentRepository;
                _mapper = mapper;
            }
            public async Task<Unit> Handle(DeletePaymentCommand request, CancellationToken cancellationToken)
            {
                Payment result = await _paymentRepository.GetElemanById(request.Input.Id);
                result.IsDeleted = true;

                await _paymentRepository.Update(result);

                return Unit.Value;
            }
        }
    }
}
