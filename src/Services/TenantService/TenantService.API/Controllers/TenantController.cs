using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TenantService.Application.Features.Tenants.Commands;
using TenantService.Application.Features.Tenants.Dtos;
using TenantService.Application.Features.Tenants.Queries;

namespace TenantService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TenantController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]

        public async Task<ActionResult<Unit>> Create([FromBody] CreateTenantInputDto input)
        {
            var query = new CreateTenantCommand()
            {
                Input = input
            };

            return Ok(await _mediator.Send(query));
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<List<GetTenantOutputDto>>> GetAll()
        {
            var query = new GetAllTenantQuery()
            {
            
            };

            return Ok(await _mediator.Send(query));
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<GetTenantOutputDto>> GetById([FromRoute] GetTenantByIdInputDto input)
        {
            var query = new GetTenantByIdQuery()
            {
                Input = input
            };

            return Ok(await _mediator.Send(query));
        }
        [HttpPut]
        public async Task<ActionResult<Unit>> Update([FromBody] UpdateTenantInputDto input)
        {
            var query = new UpdateTenantCommand()
            {
                Input = input
            };

            return Ok(await _mediator.Send(query));
        }
        [HttpDelete]
        public async Task<ActionResult<Unit>> Delete([FromBody] DeleteTenantInputDto input)
        {
            var query = new DeleteTenantCommand()
            {
                Input = input
            };

            return Ok(await _mediator.Send(query));
        }
    }
}
