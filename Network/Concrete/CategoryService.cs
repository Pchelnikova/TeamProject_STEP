using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_DAL
{
    public class CategoryService : Category
    {
        public virtual ICollection<Service> Services { get; set; }
    }
}
