using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Strategy
{
    public class StrategyApp : App
    {
        public override void MainProgram()
        {
			MallardDuck mallard = new MallardDuck();
			IFly cantFly = new FlyNoWay();
			IQuack squeak = new Squeak();
			//Can't implement functional interface with lambda expression. lambdas can implement the method after instantiated or can be used with a delegate type.
			//IFly cantFly = () => Console.WriteLine("I can't fly");
			//IQuack squeak = () => Console.WriteLine("Squeak");
			RubberDuck rubberDuckie = new RubberDuck(cantFly, squeak);
			DecoyDuck decoy = new DecoyDuck();

			Duck model = new ModelDuck();

			mallard.performQuack();
			rubberDuckie.performQuack();
			decoy.performQuack();

			model.performFly();
			model.FlyBehavior = new FlyRocketPowered();
			model.performFly();
		}
    }
}
