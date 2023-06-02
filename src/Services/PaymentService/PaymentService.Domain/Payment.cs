using CorePayment.Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Domain
{
    public enum PaymentStatusEnum
    {
        Paid = 1,
        Completed = 2,
        Failed = 3,
        Canceled = 4,

    }
    public class Payment:AuditEntity
    {

        public Payment()
        {

        }

        public Payment(int id,int tenantId, string successUrl, string errorUrl, float amount, PaymentStatusEnum paymentStatus, DateTime createdDate, DateTime? deletedTime, bool isDeleted)
        {
            Id = id;
            TenantId = tenantId;
            SuccessUrl = successUrl;
            ErrorUrl = errorUrl;
            Amount = amount;
            PaymentStatus = paymentStatus;
            CreatedTime = createdDate;
            DeletedTime = deletedTime;
            IsDeleted = isDeleted;
        }

        public int TenantId { get; set; }
        public string SuccessUrl  { get; set; }

        public string ErrorUrl { get; set; }

        public float Amount { get; set; }

        public PaymentStatusEnum PaymentStatus  { get; set; }

    }
}
