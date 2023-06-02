using AutoMapper;
using EditionService.Application.Features.Edition.Commands;
using EditionService.Application.Features.Edition.Dtos;
using EditionService.Application.Services;
using EditionService.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace EditionService.Application.Features.Edition.Queries
{
    public class GetAllEditionQuery:IRequest<List<GetEditionOutputDto>>
    {
        public class GetAllEditionQueryHandler : IRequestHandler<GetAllEditionQuery, List<GetEditionOutputDto>>
        {
            private readonly IEditionRepository _editionRepository;
            private readonly IMapper _mapper;
            public GetAllEditionQueryHandler(IEditionRepository editionRepository, IMapper mapper)
            {
                _editionRepository = editionRepository;
                _mapper = mapper;
            }
            public async Task<List<GetEditionOutputDto>> Handle(GetAllEditionQuery request, CancellationToken cancellationToken)
            {
                List<EditionInfo> editions = await _editionRepository.GetAll();
                List<GetEditionOutputDto> mappedEdition = _mapper.Map<List<EditionInfo>,List<GetEditionOutputDto>>(editions);
               
                return mappedEdition;
            }
        }

    }
}
