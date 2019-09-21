using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone.Entities
{
    public class Recipient : AuditableEntity<int>
    {
        public int BusinessUnitID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDay { get; set; }
        public bool IsDeleted { get; set; }
    }
}
