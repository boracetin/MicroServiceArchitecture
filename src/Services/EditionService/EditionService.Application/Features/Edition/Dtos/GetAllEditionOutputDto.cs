using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditionService.Application.Features.Edition.Dtos
{
    public class GetAllEditionOutputDto
    {
        public List<GetEditionOutputDto> Items { get; set; }
    }
}
