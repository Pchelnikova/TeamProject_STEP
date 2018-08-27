using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_DAL
{
    public class CategoryThing : Category
    {
        public virtual ICollection<Thing> Things { get; set; }
    }
}
