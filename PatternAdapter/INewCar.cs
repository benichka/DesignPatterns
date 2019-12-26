using System;
using System.Collections.Generic;
using System.Text;

namespace PatternAdapter
{
    interface INewCar
    {
        int Power { get; }
        int Gear { get; set; }
        int Speed { get; }

        void ChangeGear(int gearNumber);

        void Accelerate();

        void Break();
    }
}
