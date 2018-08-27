using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_DAL
{
    public class StatusUser :Status
    {
        public virtual ICollection<User> User { get; set; }
    }
}
