using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dependency_Injection
{
    public class Bagger : IGrabable
    {
        public void buddel()
        {
            Console.WriteLine("Bagger Bagger Bagger");
        }
    }
}
