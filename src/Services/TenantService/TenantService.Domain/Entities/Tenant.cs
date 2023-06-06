using CoreTenant.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TenantService.Domain.Entities
{
    public class Tenant:AuditEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int? EditionId { get; set; }

        public DateTime? SubscriptionEndDay { get; set; }
        public DateTime? SubscriptionStartDay { get; set; }
        public string? EmailAddress { get; set; }
        public Tenant()
        {

        }

        public Tenant(int id,string name, string surname, int editionId, DateTime subscriptionEndDay, DateTime subscriptionStartDay, string emailAddress,DateTime createdDate,DateTime? deletedTime,bool isDeleted)
        {
            Id = id;
            Name = name;
            Surname = surname;
            EditionId = editionId;
            SubscriptionEndDay = subscriptionEndDay;
            SubscriptionStartDay = subscriptionStartDay;
            EmailAddress = emailAddress;
            CreatedTime= createdDate;
            DeletedTime= deletedTime;
            IsDeleted= isDeleted;
        }
    }
}
