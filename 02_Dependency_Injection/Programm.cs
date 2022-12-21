using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dependency_Injection
{
    public class Programm
    {
        public static void Main(String[] args)
        {
            Meister m1= new Meister();
            m1.GibAnweisung();
        }
    }
}
