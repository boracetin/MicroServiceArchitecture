using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Application.Features.Payments.Dtos
{
    public class CreatePaymentInputDto
    {
        public int Id { get; set; }

        public int TenantId { get; set; }
        public string SuccessUrl { get; set; }

        public string ErrorUrl { get; set; }

        public float Amount { get; set; }

    }
}
