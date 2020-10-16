using System;
using PatternAdapter.Adapters;
using PatternAdapter.BadImplementation;
using PatternAdapter.Concrete;
using PatternAdapter.Contracts;
using PatternStrategy.Algorithms;
using PatternStrategy.Implementation;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Adapter.
            Console.WriteLine("---------------- ADAPTER ----------------");
            // Instanciate a legacy car and make it do some stuff.
            ILegacyCar legacyCar = new LegacyCar();
            legacyCar.ChangeGearNumber(1);
            legacyCar.SpeedUp();

            Console.WriteLine($"Legacy car info: gear {legacyCar.GearNumber}, speed is {legacyCar.Mph}");

            // Instanciate a new car based on the existing legacy car.
            // As the legacy car is a reference type (class), everything made to this
            // new car will also be made in the correct way in the legacy car.
            INewCar newCar = new LegacyCarToNewCarAdapter(legacyCar);

            // Do some stuff with the new car.
            newCar.ChangeGear(2);
            newCar.Accelerate();

            // Display the states of both car: as expected, the legacy and the new car contain the same
            // information, only adapted for the new car.
            Console.WriteLine($"New car info: gear {newCar.Gear}, speed is {newCar.Speed}");
            Console.WriteLine($"Legacy car info: gear {legacyCar.GearNumber}, speed is {legacyCar.Mph}");

            Console.WriteLine();
            #endregion Adapter.

            #region Strategy.
            Console.WriteLine("---------------- STRATEGY ----------------");
            // Instancating a new standard duck.
            BadDuck badStandardDuck = new BadStandardDuck();
            BadDuck badRubberDuck = new BadRubberDuck();

            Console.WriteLine("Bad standard duck.");
            badStandardDuck.Fly();
            badStandardDuck.Quack();
            Console.WriteLine();

            Console.WriteLine("Bad rubber duck.");
            badRubberDuck.Fly();
            badRubberDuck.Quack();
            Console.WriteLine();

            // Now we're stuck! If we need to implement new functionality in the BadDuck class, all ducks will
            // inherit it. What if some duck don't need that?
            // Also, if different duck species use the same implementation for Fly() or Quack() (but different
            // from the base class), we will have to duplicate code or create new class only for this specific
            // implementation.
            // That's when the strategy pattern comes to play.
            // First, we need to define our dependency injection, based on whatever we like (program state,
            // environment, etc.).
            // Note: the method to get a duck could be put in a factory pattern!
            Duck standardDuck = null;
            Duck rubberDuck = null;
            if (DateTime.Now.Second % 2 == 0)
            {
                standardDuck = new Duck(new StandardQuack(), new StandardFly());
            }
            else
            {
                rubberDuck = new Duck(new SqueezeQuack(), new NoFly());
            }

            if (standardDuck != null)
            {
                Console.WriteLine("Standard duck.");
                standardDuck.Fly();
                standardDuck.Quack();
            }

            if (rubberDuck != null)
            {
                Console.WriteLine("Rubber duck.");
                rubberDuck.Fly();
                rubberDuck.Quack();
            }

            Console.WriteLine();
            #endregion Strategy.
        }
    }
}
