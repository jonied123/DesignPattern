using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dependency_Injection
{
    public class Meister
    {
        public void GibAnweisung()
        {
            Lehrling l1= new Lehrling();
            Schaufel s1= new Schaufel();
            Bagger b1 = new Bagger();
            l1.Graben(s1);
            l1.Graben(b1);
        }
    }
}
