using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Strategie
{
    internal class MallardDuck : Duck
    {
        public MallardDuck() 
        {
            Quackbehavior = new Quack();
            FlyBehavior = new FlyWthWings();
        }
    }
}
