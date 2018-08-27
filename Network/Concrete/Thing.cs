using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_DAL
{
    public class Thing : Lot
    {
        public virtual CategoryThing CategoryThing { get; set; }
        public virtual StatusLot StatusLot { get; set; }
    }
}
