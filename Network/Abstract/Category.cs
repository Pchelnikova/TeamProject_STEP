using System.Collections.Generic;

namespace Network_DAL
{
    public abstract class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Lot> Lot { get; set; }
       
    }
}