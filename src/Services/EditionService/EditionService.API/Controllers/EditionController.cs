using EditionService.Application.Features.Edition.Commands;
using EditionService.Application.Features.Edition.Dtos;
using EditionService.Application.Features.Edition.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EditionService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditionController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EditionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ActionResult<Unit>> Create([FromBody] CreateEditionInputDto input)
        {
            var query = new CreateEditionCommand()
            {
                Input = input
            };

            return Ok(await _mediator.Send(query));
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<List<GetEditionOutputDto>>> GetAll()
        {
            var query = new GetAllEditionQuery()
            {
          
            };

            return Ok(await _mediator.Send(query));
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<GetEditionOutputDto>> GetEditionById([FromRoute] GetEditionByIdInputDto input)
        {
            var query = new GetEditionByIdQuery()
            {
                Input = input
            };

            return Ok(await _mediator.Send(query));
        }
        [HttpPut]
        public async Task<ActionResult<Unit>> Update([FromBody] UpdateEditionInputDto input)
        {
            var query = new UpdateEditionCommand()
            {
                Input = input
            };

            return Ok(await _mediator.Send(query));
        }
        [HttpDelete]
        public async Task<ActionResult<Unit>> Delete([FromBody] DeleteEditionInputDto input)
        {
            var query = new DeleteEditionCommand()
            {
                Input = input
            };

            return Ok(await _mediator.Send(query));
        }
    }
}
