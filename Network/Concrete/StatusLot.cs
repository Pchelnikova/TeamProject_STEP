﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_DAL
{
   public class StatusLot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<Lot> Lots { get; set; }

    }
}
