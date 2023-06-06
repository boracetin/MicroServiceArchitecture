using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Application.Features.Users.Dtos
{
    public class GetAllUserOutputDto
    {
        public List<GetUserOutputDto> Items { get; set; }

    }
}
