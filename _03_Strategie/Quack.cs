using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Strategie
{
    internal class Quack : IQuackbehavior
    {
        void IQuackbehavior.Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
