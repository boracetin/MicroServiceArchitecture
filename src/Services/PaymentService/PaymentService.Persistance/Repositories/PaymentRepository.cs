using CorePayment.Persistance.Repository;
using PaymentService.Application.Services;
using PaymentService.Domain;
using PaymentService.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Persistance.Repositories
{
    public class PaymentRepository : EfCoreGenericRepository<Payment, PaymentDbContext>, IPaymentRepository
    {
        public PaymentRepository(PaymentDbContext context) : base(context)
        {

        }

    }
}
