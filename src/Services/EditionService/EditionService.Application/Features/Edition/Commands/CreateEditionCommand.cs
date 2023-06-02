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
    public class CreateEditionCommand: IRequest<Unit>
    {
        public CreateEditionInputDto Input { get; set; }
        public class CreateEditionCommandHandler : IRequestHandler<CreateEditionCommand, Unit>
        {
            private readonly IEditionRepository _editionRepository;

            private readonly IMapper _mapper;
            public CreateEditionCommandHandler(IEditionRepository editionRepository, IMapper mapper)
            {
                _editionRepository= editionRepository;
                _mapper= mapper;    
            }
            public async Task<Unit> Handle(CreateEditionCommand request, CancellationToken cancellationToken)
            {
                EditionInfo mappedEdition = _mapper.Map<Domain.EditionInfo>(request.Input);
                mappedEdition.CreatedTime = DateTime.UtcNow;
                await _editionRepository.Create(mappedEdition);
                
                return Unit.Value;
            }
        }
    }
}
