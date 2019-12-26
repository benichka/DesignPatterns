using System;
using System.Collections.Generic;
using System.Text;

namespace PatternAdapter.Adapters
{
    class LegacyCarToNewCarAdapter : INewCar
    {
        private ILegacyCar _legacyCar;

        public int Power => _legacyCar.HorsePower;

        public int Gear => _legacyCar.GearNumber;

        public int Speed => _legacyCar.Mph;

        public LegacyCarToNewCarAdapter(ILegacyCar legacyCar)
        {
            _legacyCar = legacyCar;
        }

        public void Accelerate()
        {
            _legacyCar.SpeedUp();
        }

        public void Break()
        {
            _legacyCar.SpeedDown();
        }

        public void ChangeGear(int gearNumber)
        {
            _legacyCar.ChangeGearNumber(gearNumber);
        }
    }
}
