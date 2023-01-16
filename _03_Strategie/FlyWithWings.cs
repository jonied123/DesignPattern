using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Strategie
{

    internal class FlyWthWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can fly");
        }
    }
}
