using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone.Entities.BaseEntites
{
    public abstract class AuditableEntity<T> : Entity<T>, IAuditableEntity
    {
        public DateTime CreatedDate { get; set; }
        [MaxLength(256)]
        public string CreatedBy { get; set; }
        public Nullable<DateTime> UpdatedDate { get; set; }
        [MaxLength(256)]
        public string UpdatedBy { get; set; }
    }
}
