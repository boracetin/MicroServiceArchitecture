using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePayment.Domain
{
    public class AuditEntity : Entity
    {
        public DateTime CreatedTime { get; set; }

        public DateTime? DeletedTime { get; set; }

        public bool IsDeleted { get; set; }
    }
}
