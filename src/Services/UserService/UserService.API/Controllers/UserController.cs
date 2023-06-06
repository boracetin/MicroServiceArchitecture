using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Application.Features.Users.Commands;
using UserService.Application.Features.Users.Dtos;
using UserService.Application.Features.Users.Queries;

namespace UserService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ActionResult<Unit>> Create([FromBody] CreateUserInputDto input)
        {
            var query = new CreateUserCommand()
            {
                Input = input
            };

            return Ok(await _mediator.Send(query));
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<List<GetUserOutputDto>>> GetAll()
        {
            var query = new GetAllUserQuery()
            {

            };

            return Ok(await _mediator.Send(query));
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<GetUserOutputDto>> GetEditionById([FromRoute] GetUserByIdInputDto input)
        {
            var query = new GetUserByIdQuery()
            {
                Input = input
            };

            return Ok(await _mediator.Send(query));
        }
        [HttpPut]
        public async Task<ActionResult<Unit>> Update([FromBody] UpdateUserInputDto input)
        {
            var query = new UpdateUserCommand()
            {
                Input = input
            };

            return Ok(await _mediator.Send(query));
        }
        [HttpDelete]
        public async Task<ActionResult<Unit>> Delete([FromBody] DeleteUserInputDto input)
        {
            var query = new DeleteUserCommand()
            {
                Input = input
            };

            return Ok(await _mediator.Send(query));
        }
    }
}
