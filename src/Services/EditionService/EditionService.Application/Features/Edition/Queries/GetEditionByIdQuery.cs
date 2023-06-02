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

namespace EditionService.Application.Features.Edition.Queries
{
    public class GetEditionByIdQuery:IRequest<GetEditionOutputDto>
    {
        public GetEditionByIdInputDto Input { get; set; }

        public class GetEditionByIdQueryHandler : IRequestHandler<GetEditionByIdQuery, GetEditionOutputDto>
        {
            private readonly IEditionRepository _editionRepository;
            private readonly IMapper _mapper;
            public GetEditionByIdQueryHandler(IEditionRepository editionRepository, IMapper mapper)
            {
                _editionRepository = editionRepository;
                _mapper = mapper;
            }
            public async Task<GetEditionOutputDto> Handle(GetEditionByIdQuery request, CancellationToken cancellationToken)
            {
                Domain.EditionInfo result = await _editionRepository.GetElemanById(request.Input.Id);
                GetEditionOutputDto mappedEdition = _mapper.Map<GetEditionOutputDto>(result);

                return mappedEdition;
            }
        }

    }
}
