using CorePayment.Persistance.Repository;
using PaymentService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Application.Services
{
    public interface IPaymentRepository: IRepository<Payment>
    {
    }
}
