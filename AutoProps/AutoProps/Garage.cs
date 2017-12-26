using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Garage
    {
        public int NumbersOfCars { get; set; } = 1;
        public Car MyAuto { get; set; } = new Car();

        public Garage() {}

        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumbersOfCars = number;
        }
    }
}
