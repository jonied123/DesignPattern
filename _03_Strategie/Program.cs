namespace _03_Strategie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MallardDuck d1 = new MallardDuck();
            d1.performQuack();
            d1.performFly();

            RubberDuck d2 = new RubberDuck();
            d2.performQuack();
            d2.performFly();
            d2.FlyBehavior = new FlyWithRocket();
            d2.performFly();
        }
    }
}