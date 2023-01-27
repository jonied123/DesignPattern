using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Factory
{
    public class PizzaFactory
    {
        public Pizza CreatePizza(string name) 
        {
            if (name == "Greek")
            {
                return new Pizza();
            }
            if (name == "Chees")
            {
                return new Pizza();
            }
            return null;
        }
    }
}
