using System;
using System.Collections.Generic;

namespace Network_DAL
{
    public abstract class Lot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date_Create { get; set; }
        public string Description { get; set; }
        //EF navigation property
        public virtual Transaction Transactions { get; set; }
        public virtual Category Categories { get; set; }       
        public virtual User Users { get; set; }
    }
}
