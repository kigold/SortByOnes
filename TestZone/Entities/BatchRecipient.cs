using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestZone.Entities.BaseEntites;

namespace TestZone.Entities
{
    public class BatchRecipient
    {
        public int Id { get; set; }
        public int RecipientID { get; set; }
        public int BatchID { get; set; }
        public virtual ICollection<Recipient> Recipients { get; set; }
    }
}
}
