using System;
using System.Collections.Generic;
using System.Text;

namespace PatternAdapter
{
    class NewCar : INewCar
    {
        private int _power;
        public int Power { get => _power; }
        public int Gear { get; set; }

        private int _speed;
        public int Speed { get => _speed; }

        public NewCar()
        {
            _speed = 0;
            Gear = 0;
            _power = 150;
        }
        public void Accelerate()
        {
            _speed += 5;
        }

        public void Break()
        {
            _speed -= 5;
        }

        public void ChangeGear(int gearNumber)
        {
            Gear = gearNumber;
        }
    }
}
