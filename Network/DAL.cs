using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_DAL
{
    public class DAL
    {
        private readonly Model_Network _ctx;
        public DAL(Model_Network ctx)
        {
            _ctx = ctx;
        }


        public string GetName()
        {
           
            return _ctx.Users.Where(u => u.Name == "Name"). ToString();
        }
    }
}
