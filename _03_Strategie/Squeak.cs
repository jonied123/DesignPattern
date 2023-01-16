using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Strategie
{
    internal class Squeak : IQuackbehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeeak!");
        }
    }
}
