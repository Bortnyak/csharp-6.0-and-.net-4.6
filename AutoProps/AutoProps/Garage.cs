using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Garage
    {
        public int NumbersOfCars { get; set; }
        public Car MyAuto { get; set; }

        public Garage()
        {
            MyAuto = new Car();
            NumbersOfCars = 1;
        }

        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumbersOfCars = number;
        }
    }
}
