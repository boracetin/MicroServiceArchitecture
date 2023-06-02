using AutoMapper;
using EditionService.Application.Features.Edition.Dtos;
using EditionService.Application.Services;
using EditionService.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditionService.Application.Features.Edition.Commands
{
    public class DeleteEditionCommand:IRequest<Unit>
    {
        public DeleteEditionInputDto Input { get; set; }


        public class DeleteEditionCommandHandler : IRequestHandler<DeleteEditionCommand, Unit>
        {
            private readonly IEditionRepository _editionRepository;
            private readonly IMapper _mapper;
            public DeleteEditionCommandHandler(IEditionRepository editionRepository, IMapper mapper)
            {
                _editionRepository= editionRepository;
                _mapper= mapper;
            }
            public async Task<Unit> Handle(DeleteEditionCommand request, CancellationToken cancellationToken)
            {
                EditionInfo result = await _editionRepository.GetElemanById(request.Input.Id);
                result.IsDeleted = true;
                await _editionRepository.Update(result);
                return Unit.Value;
            }
        }
    }
}
