using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Application.Features.Payments.Enums
{
    public enum PaymentStatusEnum
    {
        Paid = 1,
        Completed = 2,
        Failed = 3,
        Canceled = 4,
    }

}
