using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network_DAL;

namespace ConsoleTEST
{
    class Program
    {
        static void Main(string[] args)
        {
         Model_Network _ctx = new Model_Network();
         DAL dal = new DAL(_ctx);
         Console.WriteLine(dal.GetName());
        }
    }
}
