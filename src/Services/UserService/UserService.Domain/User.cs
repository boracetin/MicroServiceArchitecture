using CoreUser.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Domain
{
    public class User:AuditEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string EmailAddress { get; set; }

        public int TenantId { get; set; }

        public User()
        {

        }

        public User(int id,string name, string surname, string emailAddress, int tenantId, DateTime createdDate, DateTime? deletedTime, bool isDeleted)
        {
            Id= id;
            Name = name;
            Surname = surname;
            EmailAddress = emailAddress;
            TenantId = tenantId;
            CreatedTime = createdDate;
            DeletedTime = deletedTime; 
            IsDeleted= isDeleted;
        }
    }
}
