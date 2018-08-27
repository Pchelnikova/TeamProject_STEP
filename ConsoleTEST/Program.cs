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
        
            DAL dal = new DAL();
            Console.WriteLine(dal.GetName());
        }
    }
}
