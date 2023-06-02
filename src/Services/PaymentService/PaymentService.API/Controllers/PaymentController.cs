using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentService.Application.Features.Payments.Commands;
using PaymentService.Application.Features.Payments.Dtos;
using PaymentService.Application.Features.Payments.Queries;

namespace PaymentService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PaymentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        
        public async Task<ActionResult<Unit>> Create([FromBody] CreatePaymentInputDto input)
        {
            var query = new CreatePaymentCommand()
            {
                Input = input
            };

            return Ok(await _mediator.Send(query));
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<List<GetPaymentOutputDto>>> GetAll()
        {
            var query = new GetAllPaymentQuery()
            {
         
            };

            return Ok(await _mediator.Send(query));
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<GetPaymentOutputDto>> GetPaymentById([FromRoute] GetPaymentByIdInputDto input)
        {
            var query = new GetPaymentByIdQuery()
            {
                Input = input
            };

            return Ok(await _mediator.Send(query));
        }
        [HttpPut]
        public async Task<ActionResult<Unit>> Update([FromBody] UpdatePaymentInputDto input)
        {
            var query = new UpdatePaymentCommand()
            {
                Input = input
            };

            return Ok(await _mediator.Send(query));
        }
        [HttpDelete]
        public async Task<ActionResult<Unit>> Delete([FromBody] DeletePaymentInputDto input)
        {
            var query = new DeletePaymentCommand()
            {
                Input = input
            };

            return Ok(await _mediator.Send(query));
        }
    }
}
