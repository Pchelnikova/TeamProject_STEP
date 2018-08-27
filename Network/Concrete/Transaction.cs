using System.Collections.Generic;

namespace Network_DAL
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }       

        public virtual ICollection<Lot> Lots { get; set; }
       
    }
}