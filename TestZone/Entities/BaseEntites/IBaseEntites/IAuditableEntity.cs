using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone.Entities.BaseEntites.IBaseEntites
{
    public interface IAuditableEntity
    {
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }
        Nullable<DateTime> UpdatedDate { get; set; }
        string UpdatedBy { get; set; }
    }
}
