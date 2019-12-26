using PatternAdapter.Adapters;
using System;

namespace PatternAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ILegacyCar legacyCar = new LegacyCar();
            legacyCar.ChangeGearNumber(1);
            legacyCar.SpeedUp();

            Console.WriteLine($"Legacy car info: gear {legacyCar.GearNumber}, speed is {legacyCar.Mph}");

            INewCar newCar = new LegacyCarToNewCarAdapter(legacyCar);
            newCar.ChangeGear(2);
            newCar.Accelerate();

            Console.WriteLine($"New car info: gear {newCar.Gear}, speed is {newCar.Speed}");
            Console.WriteLine($"Legacy car info: gear {legacyCar.GearNumber}, speed is {legacyCar.Mph}");
        }
    }
}
