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
    public class UpdateEditionCommand:IRequest<Unit>
    {
        public UpdateEditionInputDto Input{ get; set; }

        public class UpdateEditionCommandHandler : IRequestHandler<UpdateEditionCommand, Unit>
        {
            private readonly IEditionRepository _editionRepository;
            private readonly IMapper _mapper;
            public UpdateEditionCommandHandler(IEditionRepository editionRepository, IMapper mapper)
            {
                _editionRepository = editionRepository;
                _mapper = mapper;
            }
            public async Task<Unit> Handle(UpdateEditionCommand request, CancellationToken cancellationToken)
            {
                EditionInfo mappedEdition = await _editionRepository.GetElemanById(request.Input.Id);
                mappedEdition.Name = request.Input.Name;
                mappedEdition.TrialDay = request.Input.TrialDay;
                mappedEdition.Price = request.Input.Price;  

                await _editionRepository.Update(mappedEdition);

                return Unit.Value;
            }
        }
    }
}
