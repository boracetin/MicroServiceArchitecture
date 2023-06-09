﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantService.Application.Features.Tenants.Dtos
{
    public class DeleteTenantInputDto
    {
        public DeleteTenantInputDto(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

     
    }
}
