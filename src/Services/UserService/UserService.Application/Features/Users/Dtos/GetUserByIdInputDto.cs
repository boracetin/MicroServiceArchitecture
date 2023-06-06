﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Application.Features.Users.Dtos
{
    public class GetUserByIdInputDto
    {
        public int Id { get; set; }


        public GetUserByIdInputDto()
        {


        }

        public GetUserByIdInputDto(int id)
        {
            Id = id;
        }
    }
}
