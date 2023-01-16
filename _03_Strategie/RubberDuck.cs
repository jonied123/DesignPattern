using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Strategie
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            Quackbehavior = new Squeak();
            FlyBehavior = new FlyNoWay();
        }
    }
}
