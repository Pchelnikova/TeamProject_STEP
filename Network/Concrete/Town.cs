
using System.Collections.Generic;

namespace Network_DAL
{
    public class Town
    {
        public int Id { get; set; }
        public string Name { get; set; }

         public virtual ICollection<User> Users { get; set; }
    }
}