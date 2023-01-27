using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Factory
{
    public class Pizzashop
    {
        public Pizza pizza { get; set;}

        public void CreatePizza(string par)
        {
            pizza = new PizzaFactory().CreatePizza(par);

            bakePizza();
            cutPizza();
            boxPizza();
        }

        private void boxPizza()
        {
            Console.WriteLine("Packing Pizza");
        }

        private void cutPizza()
        {
            Console.WriteLine("Cutting Pizza");
        }

        private void bakePizza()
        {
            Console.WriteLine("Baking Pizza");
        }
    }
}
