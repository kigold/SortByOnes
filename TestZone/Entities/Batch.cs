using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone.Entities
{
    public class Batch : AuditableEntity<int>
    {
        public string Name { get; set; }
        public int BusinessUnitID { get; set; }
        public bool IsDeleted { get; set; }

        
    }
}
