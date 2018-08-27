using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_DAL
{
   public class StatusLot :Status
    {
        public virtual ICollection<Lot> Lot { get; set; }
    }
}
