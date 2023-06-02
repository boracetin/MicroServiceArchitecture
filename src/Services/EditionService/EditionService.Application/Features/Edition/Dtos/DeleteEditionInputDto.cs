using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditionService.Application.Features.Edition.Dtos
{
    public class DeleteEditionInputDto
    {
        public DeleteEditionInputDto(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name{ get; set; }
    }
}
