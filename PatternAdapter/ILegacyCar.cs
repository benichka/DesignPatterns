using System;
using System.Collections.Generic;
using System.Text;

namespace PatternAdapter
{
    interface ILegacyCar
    {
        int HorsePower { get; }
        int GearNumber { get; }
        int Mph { get; }

        void ChangeGearNumber(int gearNumber);

        void SpeedUp();

        void SpeedDown();
    }
}
