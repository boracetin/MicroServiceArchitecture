using CoreEdition.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditionService.Domain
{
    public class EditionInfo : AuditEntity
    {
        public EditionInfo(int id,string name, float price, int trialDay, DateTime createdDate, DateTime? deletedTime, bool isDeleted)
        {
            Id= id;
            Name = name;
            Price = price;
            TrialDay = trialDay;
            CreatedTime = createdDate;
            DeletedTime = deletedTime;
            IsDeleted = isDeleted;
        }

        public EditionInfo()
        {

        }

        public string Name { get; set; }
        public float Price { get; set; }
        public int TrialDay { get; set; }


    
    }
}
