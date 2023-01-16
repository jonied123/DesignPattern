using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Strategie
{
    internal abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackbehavior Quackbehavior { get; set; }

        public void performQuack()
        {
            Quackbehavior.Quack();
        }
        public void performFly()
        {
            FlyBehavior.Fly();
        }
    }
}
