﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Application.Features.Payments.Dtos
{
    public class UpdatePaymentInputDto
    {
        public int Id { get; set; }

        public string SuccessUrl { get; set; }
    }
}
