﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Application.Features.Users.Dtos
{
    public class UpdateUserInputDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
